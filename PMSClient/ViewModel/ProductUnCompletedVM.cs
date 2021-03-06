﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using PMSClient.MainService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSClient.ViewModel
{
    public class ProductUnCompletedVM : BaseViewModelPage
    {
        public ProductUnCompletedVM()
        {
            InitializeCommands();
            InitializeProperties();
            SetPageParametersWhenConditionChange();
        }

        public void RefreshData()
        {
            SetPageParametersWhenConditionChange();
        }

        private void InitializeCommands()
        {
            PageChanged = new RelayCommand(ActionPaging);
            Search = new RelayCommand(ActionSearch, CanSearch);
            All = new RelayCommand(ActionAll);
            Add = new RelayCommand(ActionAdd, CanAdd);
            Edit = new RelayCommand<DcProduct>(ActionEdit, CanEdit);
            Duplicate = new RelayCommand<DcProduct>(ActionDuplicate, CanDuplicate);
            Doc = new RelayCommand<DcProduct>(ActionDoc, CanDoc);
            SearchRecordTest = new RelayCommand<DcProduct>(ActionRecordTest, CanRecordTest);
            SelectAndSend = new RelayCommand<DcProduct>(ActionSelectAndSend,CanSelect);
            GiveUp = new RelayCommand(() => NavigationService.GoTo(PMSViews.Product));
        }

        private bool CanDuplicate(DcProduct arg)
        {
            return PMSHelper.CurrentSession.IsAuthorized(PMSAccess.EditProduct);
        }

        private void ActionDuplicate(DcProduct model)
        {
            if (PMSDialogService.ShowYesNo("请问", "确定复用这条记录？"))
            {
                PMSHelper.ViewModels.ProductEdit.SetDuplicate(model);
                NavigationService.GoTo(PMSViews.ProductEdit);
            }
        }

        private bool CanSelect(DcProduct arg)
        {
            return PMSHelper.CurrentSession.IsAuthorized(PMSAccess.EditProduct);
        }

        private void ActionSelectAndSend(DcProduct model)
        {
            if (!PMSDialogService.ShowYesNo("请问","确定设置为发货状态吗？"))
            {
                return;
            }

            if (model!=null)
            {
                using (var service=new ProductServiceClient())
                {
                    model.State = PMSCommon.InventoryState.发货.ToString();
                    service.UpdateProduct(model);
                }
                SetPageParametersWhenConditionChange();
            }
        }

        private bool CanRecordTest(DcProduct arg)
        {
            return PMSHelper.CurrentSession.IsAuthorized(PMSAccess.ReadRecordTest);
        }

        private void ActionRecordTest(DcProduct model)
        {
            if (model != null)
            {
                PMSHelper.ViewModels.RecordTest.SetSearch("", model.ProductID);
                NavigationService.GoTo(PMSViews.RecordTest);
            }
        }
        private bool CanDoc(DcProduct arg)
        {
            return PMSHelper.CurrentSession.IsAuthorized(PMSAccess.EditProduct);
        }

        private bool CanEdit(DcProduct arg)
        {
            return PMSHelper.CurrentSession.IsAuthorized(PMSAccess.EditProduct);
        }

        private bool CanAdd()
        {
            return PMSHelper.CurrentSession.IsAuthorized(PMSAccess.EditProduct);
        }


        private bool CanSearch()
        {
            return !(string.IsNullOrEmpty(SearchProductID) && string.IsNullOrEmpty(SearchCompositionStd));
        }

        private void ActionAll()
        {
            SearchProductID = SearchCompositionStd = "";
            SetPageParametersWhenConditionChange();
        }

        private void ActionSearch()
        {
            SetPageParametersWhenConditionChange();
        }

        private void ActionEdit(DcProduct model)
        {
            PMSHelper.ViewModels.ProductEdit.SetEdit(model);
            NavigationService.GoTo(PMSViews.ProductEdit);
        }

        private void ActionDoc(DcProduct model)
        {
            if (model != null)
            {
                //PMSHelper.ViewModels.ProductDoc.SetModel(model);
                //NavigationService.GoTo(PMSViews.ProductDoc);
            }

        }

        private void ActionAdd()
        {
            PMSHelper.ViewModels.ProductEdit.SetNew();
            NavigationService.GoTo(PMSViews.ProductEdit);
        }

        private void InitializeProperties()
        {
            Products = new ObservableCollection<DcProduct>();
            SearchCompositionStd = searchProductID = "";

        }
        private void SetPageParametersWhenConditionChange()
        {
            PageIndex = 1;
            PageSize = 30;
            using (var service = new ProductServiceClient())
            {
                RecordCount = service.GetProductCountUnCompleted(SearchProductID, SearchCompositionStd);
            }
            ActionPaging();
        }
        private void ActionPaging()
        {
            int skip, take = 0;
            skip = (PageIndex - 1) * PageSize;
            take = PageSize;
            using (var service = new ProductServiceClient())
            {
                var orders = service.GetProductUnCompleted(skip, take, SearchProductID, SearchCompositionStd);
                Products.Clear();
                orders.ToList().ForEach(o => Products.Add(o));
            }
            CurrentSelectItem = Products.FirstOrDefault();
        }

        private string searchProductID;
        public string SearchProductID
        {
            get { return searchProductID; }
            set
            {
                if (searchProductID == value)
                    return;
                searchProductID = value;
                RaisePropertyChanged(() => SearchProductID);
            }
        }
        private string searchCompositionStd;
        public string SearchCompositionStd
        {
            get { return searchCompositionStd; }
            set
            {
                if (searchCompositionStd == value)
                    return;
                searchCompositionStd = value;
                RaisePropertyChanged(() => SearchCompositionStd);
            }
        }

        public ObservableCollection<DcProduct> Products { get; set; }

        private DcProduct currentSelectItem;
        public DcProduct CurrentSelectItem
        {
            get { return currentSelectItem; }
            set { currentSelectItem = value; RaisePropertyChanged(nameof(CurrentSelectItem)); }
        }

        #region Commands
        public RelayCommand Add { get; set; }
        public RelayCommand<DcProduct> Edit { get; set; }
        public RelayCommand<DcProduct> Duplicate { get; set; }
        public RelayCommand<DcProduct> Doc { get; set; }
        public RelayCommand<DcProduct> SearchRecordTest { get; set; }
        public RelayCommand<DcProduct> SelectAndSend { get; set; }
        public RelayCommand GiveUp { get; set; }

        #endregion

    }
}
