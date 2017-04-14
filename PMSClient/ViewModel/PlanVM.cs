﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMSClient.MainService;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using System.Collections.ObjectModel;

namespace PMSClient.ViewModel
{
    public class PlanVM : BaseViewModelPage
    {
        public PlanVM()
        {
            IntitializeCommands();
            IntitializeProperties();
            SetPageParametersWhenConditionChange();
        }

        private void ActionRefresh(string obj)
        {
            SetPageParametersWhenConditionChange();
        }

        private void IntitializeProperties()
        {
            MissonWithPlans = new ObservableCollection<DcMissonWithPlan>();
        }

        private void IntitializeCommands()
        {
            GoToMisson = new RelayCommand(() => NavigationService.GoTo(PMSViews.Misson));
            Refresh = new RelayCommand(ActionRefresh);
            PageChanged = new RelayCommand(ActionPaging);
            GoToSearchPlan = new RelayCommand(() => NavigationService.GoTo(PMSViews.PlanSearch));
        }

        private void ActionRefresh()
        {
            SetPageParametersWhenConditionChange();
        }

        private void SetPageParametersWhenConditionChange()
        {
            PageIndex = 1;
            PageSize = 20;
            var service = new MissonServiceClient();
            //只显示Checked过的计划
            RecordCount = service.GetMissonWithPlanCheckedCount();
            ActionPaging();
        }
        /// <summary>
        /// 分页动作的时候读入数据
        /// </summary>
        private void ActionPaging()
        {
            var service = new MissonServiceClient();
            int skip, take = 0;
            skip = (PageIndex - 1) * PageSize;
            take = PageSize;
            //只显示Checked过的计划
            var orders = service.GetMissonWithPlanChecked(skip, take);
            MissonWithPlans.Clear();
            orders.ToList().ForEach(o => MissonWithPlans.Add(o));
        }

        #region Commands
        public RelayCommand GoToMisson { get; set; }
        public RelayCommand Refresh { get; set; }

        public RelayCommand GoToSearchPlan { get; set; }
        #endregion

        #region Properties
        public ObservableCollection<DcMissonWithPlan> MissonWithPlans { get; set; }
        #endregion

    }
}
