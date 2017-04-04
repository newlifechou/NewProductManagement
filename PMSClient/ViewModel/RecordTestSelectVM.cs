﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using PMSClient.MainService;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Messaging;

namespace PMSClient.ViewModel
{
    public class RecordTestSelectVM : BaseViewModelPage
    {
        private DcRecordDeliveryItem item;
        public RecordTestSelectVM(ModelObject model)
        {
            item = new MainService.DcRecordDeliveryItem();
            item.ID = Guid.NewGuid();
            item.DeliveryID = (model.Model as DcRecordDelivery).ID;
            item.State = PMSCommon.SimpleState.UnDeleted.ToString();



            InitializeProperties();
            InitializeCommands();
            SetPageParametersWhenConditionChange();
        }

        private void InitializeCommands()
        {
            GiveUp = new RelayCommand(() =>
            {
                NavigationService.GoTo(new MsgObject() { MsgToken = VToken.RecordDelivery });
                NavigationService.Refresh(VToken.RecordDeliveryRefresh);
            });
            PageChanged = new RelayCommand(ActionPaging);
            Search = new RelayCommand(ActionSearch, CanSearch);
            All = new RelayCommand(ActionAll);
            Select = new RelayCommand<DcRecordTest>(ActionSelect);
            Empty = new RelayCommand(ActionEmpty);
        }

        private void ActionEmpty()
        {
            MsgObject msg = new PMSClient.MsgObject();

            item.ProductType = PMSCommon.ProductType.Target.ToString();
            item.ProductID = "";
            item.Composition = "";
            item.Abbr = "";
            item.PO = "";
            item.Customer = "";
            item.Weight = "";
            item.DetailRecord = "";
            item.Remark = "";

            msg.MsgToken = VToken.RecordDeliveryItemEdit;
            msg.MsgModel = new PMSClient.ModelObject() { IsNew = true, Model = item };
            NavigationService.GoTo(msg);
        }

        private bool CanSearch()
        {
            return !(string.IsNullOrEmpty(SearchProductID) && string.IsNullOrEmpty(SearchCompositonStd));
        }

        private void ActionAll()
        {
            SearchProductID = SearchCompositonStd = "";
            ActionPaging();
        }

        private void ActionSearch()
        {
            ActionPaging();
        }

        private void ActionSelect(DcRecordTest obj)
        {
            MsgObject msg = new PMSClient.MsgObject();

            item.ProductType = PMSCommon.ProductType.Target.ToString();
            item.ProductID = obj.ProductID;
            item.Composition = obj.Composition;
            item.Abbr = obj.CompositionAbbr;
            item.PO = obj.PO;
            item.Customer = obj.Customer;
            item.Weight = obj.Weight;
            item.DetailRecord = "";
            item.Remark = "";

            msg.MsgToken = VToken.RecordDeliveryItemEdit;
            msg.MsgModel = new PMSClient.ModelObject() { IsNew = true, Model = item };
            NavigationService.GoTo(msg);
        }

        private void InitializeProperties()
        {
            RecordProducts = new ObservableCollection<DcRecordTest>();
            SearchCompositonStd = searchProductID = "";

        }
        private void SetPageParametersWhenConditionChange()
        {
            PageIndex = 1;
            PageSize = 10;
            var service = new RecordTestServiceClient();
            RecordCount = service.GetRecordTestCountBySearchInPage(SearchProductID, SearchCompositonStd);
            ActionPaging();
        }
        private void ActionPaging()
        {
            var service = new RecordTestServiceClient();
            int skip, take = 0;
            skip = (PageIndex - 1) * PageSize;
            take = PageSize;
            var orders = service.GetRecordTestBySearchInPage(skip, take, SearchProductID, SearchCompositonStd);
            RecordProducts.Clear();
            orders.ToList<DcRecordTest>().ForEach(o => RecordProducts.Add(o));
        }
        #region Commands
        public RelayCommand GiveUp { get; set; }
        public RelayCommand<DcRecordTest> Select { get; set; }

        public RelayCommand Empty { get; set; }
        #endregion
     
        #region Properties
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
        public string SearchCompositonStd
        {
            get { return searchCompositionStd; }
            set
            {
                if (searchCompositionStd == value)
                    return;
                searchCompositionStd = value;
                RaisePropertyChanged(() => SearchCompositonStd);
            }
        }

        public ObservableCollection<DcRecordTest> RecordProducts { get; set; }
        #endregion
    }
}
