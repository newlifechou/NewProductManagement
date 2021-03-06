﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using PMSCommon;
using PMSClient.MainService;
using System.Collections.ObjectModel;
using AutoMapper;
using System.Windows;
using PMSClient;
using Novacode;
using PMSClient.ReportsHelper;

namespace PMSClient.ViewModel
{
    public class MaterialOrderItemListUnCompletedVM : BaseViewModelPage
    {
        public MaterialOrderItemListUnCompletedVM()
        {
            InitializeProperties();
            InitializeCommands();
            SetPageParametersWhenConditionChange();
        }
        public void RefreshData()
        {
            SetPageParametersWhenConditionChange();
        }
        public void RefreshDataItem()
        {
            ActionSelectionChanged(CurrentSelectItem);
        }

        private void InitializeProperties()
        {
            SearchPMINumber = "";
            SearchSupplier = "";
            SearchComposition = "";
            SearchOrderItemNumber = "";
            MaterialOrderItemExtras = new ObservableCollection<DcMaterialOrderItemExtra>();
        }
        private void InitializeCommands()
        {
            PageChanged = new RelayCommand(ActionPaging);
            Search = new RelayCommand(ActionSearch, CanSearch);
            All = new RelayCommand(this.ActionAll);
            Doc = new RelayCommand<DcMaterialOrderItemExtra>(ActionGenerateDoc);
            SelectionChanged = new RelayCommand<DcMaterialOrderItemExtra>(ActionSelectionChanged);
            Location = new RelayCommand<DcMaterialOrderItemExtra>(ActionLocation);
            GiveUp = new RelayCommand(() => NavigationService.GoTo(PMSViews.MaterialOrder));
        }

        private void ActionLocation(DcMaterialOrderItemExtra model)
        {
            PMSHelper.ViewModels.MaterialOrder.SetSearch(model.MaterialOrder.OrderPO, "");
            NavigationService.GoTo(PMSViews.MaterialOrder);
        }

        private void ActionSelectionChanged(DcMaterialOrderItemExtra model)
        {
            if (model != null)
            {
                //using (var service = new MaterialOrderServiceClient())
                //{
                //    var result = service.GetMaterialOrderItembyMaterialID(model.ID);
                //    MaterialOrderItems.Clear();
                //    result.ToList().ForEach(i => MaterialOrderItems.Add(i));
                //    CurrentSelectItem = model;
                //}
            }
        }

        /// <summary>
        /// 生成报告部分
        /// </summary>
        /// <param name="order"></param>
        private void ActionGenerateDoc(DcMaterialOrderItemExtra order)
        {
            if (MessageBox.Show("你确定要在桌面上创建文档吗?", "请问",
                MessageBoxButton.YesNo, MessageBoxImage.Information)
                == MessageBoxResult.No)
            {
                return;
            }

            try
            {
                if (order != null)
                {
                    //NavigationService.Status("开始创建报告……");
                    //ReportMaterialOrderHorizontal report = new ReportMaterialOrderHorizontal();
                    //report.SetModel(order);
                    //report.Output();
                    //PMSDialogService.ShowYes("原材料报告创建成功，请在桌面查看");
                    //NavigationService.Status("原材料订单创建完毕！");
                }
            }
            catch (Exception ex)
            {
                PMSHelper.CurrentLog.Error(ex);
                NavigationService.Status(ex.Message);
            }
        }

        private bool CanSearch()
        {
            return !(string.IsNullOrEmpty(SearchPMINumber) && string.IsNullOrEmpty(SearchSupplier)
                && string.IsNullOrEmpty(SearchComposition) && string.IsNullOrEmpty(SearchOrderItemNumber));
        }

        private void ActionAll()
        {
            searchPMINumber = "";
            searchSupplier = "";
            searchOrderItemNumber = "";
            searchComposition = "";
            SetPageParametersWhenConditionChange();
        }

        private void ActionSearch()
        {
            SetPageParametersWhenConditionChange();
        }

        private void SetPageParametersWhenConditionChange()
        {
            PageIndex = 1;
            PageSize = 30;
            var service = new MaterialOrderServiceClient();
            RecordCount = service.GetMaterialOrderItemExtrasCountUnCompleted(SearchComposition, SearchPMINumber,
                SearchOrderItemNumber, SearchSupplier);
            service.Close();
            ActionPaging();
        }
        /// <summary>
        /// 分页动作的时候读入数据
        /// </summary>
        private void ActionPaging()
        {

            int skip, take = 0;
            skip = (PageIndex - 1) * PageSize;
            take = PageSize;
            var service = new MaterialOrderServiceClient();
            var orders = service.GetMaterialOrderItemExtrasUnCompleted(skip, take, SearchComposition, SearchPMINumber,
                SearchOrderItemNumber, SearchSupplier);
            service.Close();
            MaterialOrderItemExtras.Clear();
            orders.ToList().ForEach(o => MaterialOrderItemExtras.Add(o));

            CurrentSelectItem = MaterialOrderItemExtras.FirstOrDefault();
            ActionSelectionChanged(CurrentSelectItem);
        }


        #region Proeperties
        private string searchOrderItemNumber;

        public string SearchOrderItemNumber
        {
            get { return searchOrderItemNumber; }
            set
            {
                searchOrderItemNumber = value;
                RaisePropertyChanged(nameof(SearchOrderItemNumber));
            }
        }

        private string searchPMINumber;
        public string SearchPMINumber
        {
            get { return searchPMINumber; }
            set
            {
                if (searchPMINumber == value)
                    return;
                searchPMINumber = value;
                RaisePropertyChanged(() => SearchPMINumber);
            }
        }
        private string searchSupplier;
        public string SearchSupplier
        {
            get { return searchSupplier; }
            set
            {
                if (searchSupplier == value)
                    return;
                searchSupplier = value;
                RaisePropertyChanged(() => SearchSupplier);
            }
        }
        private string searchComposition;
        public string SearchComposition
        {
            get { return searchComposition; }
            set
            {
                if (searchComposition == value)
                    return;
                searchComposition = value;
                RaisePropertyChanged(() => SearchComposition);
            }
        }
        public ObservableCollection<DcMaterialOrderItemExtra> MaterialOrderItemExtras { get; set; }

        private DcMaterialOrderItemExtra currentSelectItem;
        public DcMaterialOrderItemExtra CurrentSelectItem
        {
            get { return currentSelectItem; }
            set
            {
                currentSelectItem = value;
                RaisePropertyChanged(nameof(CurrentSelectItem));
            }
        }


        #endregion

        #region Commands
        public RelayCommand<DcMaterialOrderItemExtra> Doc { get; private set; }
        public RelayCommand<DcMaterialOrderItemExtra> SelectionChanged { get; set; }
        public RelayCommand GiveUp { get; set; }
        public RelayCommand<DcMaterialOrderItemExtra> Location { get; set; }
        #endregion
    }
}
