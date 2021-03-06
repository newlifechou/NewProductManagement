﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMSClient.MainService;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;

namespace PMSClient.DataProcess.ScanInput
{
    public class ScanInputOutsideProcessVM : ScanInputVMBase
    {
        public ScanInputOutsideProcessVM()
        {
            SourceTarget = $"测试记录 => 外协追踪记录(不查重)";
            process = new ProcessOutsideProcess();

            Process = new RelayCommand(ActionProcess,CanCheck);
            Check = new RelayCommand(ActionCheck,CanCheck);
            Lots = new ObservableCollection<LotModel>();
        }



        private bool CanCheck()
        {
            return canClick;
        }

        private ProcessOutsideProcess process;

        private void ActionCheck()
        {
            ClearLots();
            Task task = new Task(() =>
            {
                canClick = false;
                process.Intialize(InputText);
                process.OutisideProcosser = CurrentText;

                process.Check(i =>
                {
                    ProgressValue = i;
                });
                App.Current.Dispatcher.Invoke(() =>
                {
                    RefreshLotsStatus();

                });
                canClick = true;
            });
            task.Start();
        }

        private void ActionProcess()
        {
            if (PMSDialogService.ShowYesNo("请问", "确定继续吗？") == false)
                return;
            ClearLots();
            Task task = new Task(() =>
            {
                canClick = false;
                process.Intialize(InputText);
                process.OutisideProcosser = CurrentText;

                process.Process(i =>
                {
                    ProgressValue = i;
                });
                App.Current.Dispatcher.Invoke(() =>
                {
                    RefreshLotsStatus();

                });
                canClick = true;
            });

            task.Start();
        }
        private void ClearLots()
        {
            Lots.Clear();
        }
        private void RefreshLotsStatus()
        {
            Lots.Clear();
            process.Lots.ForEach(i =>
            {
                Lots.Add(i);
            });

            PMSDialogService.Show("结束", "处理结束");

        }
    }
}
