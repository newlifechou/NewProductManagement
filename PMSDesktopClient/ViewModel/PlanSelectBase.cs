﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMSDesktopClient.PMSMainService;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using System.Collections.ObjectModel;

namespace PMSDesktopClient.ViewModel
{
    public class PlanSelectBase : ViewModelBase
    {
        public PlanSelectBase()
        {
            IntitializeCommands();
            IntitializeProperties();
            SetPageParametersWhenConditionChange();
        }

        private void IntitializeProperties()
        {
            MissonWithPlans = new ObservableCollection<DcMissonWithPlan>();

        }

        private void IntitializeCommands()
        {
            PageChanged = new RelayCommand(ActionPaging);
        }

        private void SetPageParametersWhenConditionChange()
        {
            PageIndex = 1;
            PageSize = 20;
            var service = new MissonWithPlanServiceClient();
            RecordCount = service.GetMissonWithPlanCount();
            ActionPaging();
        }
        /// <summary>
        /// 分页动作的时候读入数据
        /// </summary>
        private void ActionPaging()
        {
            var service = new MissonWithPlanServiceClient();
            int skip, take = 0;
            skip = (PageIndex - 1) * PageSize;
            take = PageSize;
            var orders = service.GetMissonWithPlan(skip, take);
            MissonWithPlans.Clear();
            orders.ToList<DcMissonWithPlan>().ForEach(o => MissonWithPlans.Add(o));
        }





        #region PagingProperties
        private int pageIndex;
        public int PageIndex
        {
            get { return pageIndex; }
            set
            {
                pageIndex = value;
                RaisePropertyChanged(nameof(PageIndex));
            }
        }

        private int pageSize;
        public int PageSize
        {
            get { return pageSize; }
            set
            {
                pageSize = value;
                RaisePropertyChanged(nameof(PageSize));
            }
        }

        private int recordCount;
        public int RecordCount
        {
            get { return recordCount; }
            set
            {
                recordCount = value;
                RaisePropertyChanged(nameof(RecordCount));
            }
        }
        public RelayCommand PageChanged { get; private set; }
        #endregion

        #region Commands
        public RelayCommand GiveUp { get; set; }
        public RelayCommand<DcMissonWithPlan> Select { get; set; }
        #endregion

        #region Properties
        public ObservableCollection<DcMissonWithPlan> MissonWithPlans { get; set; }
        #endregion

    }
}
