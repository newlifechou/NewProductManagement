﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using PMSTabletClient.PMSMainService;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Messaging;

namespace PMSTabletClient.ViewModel
{
    public class RecordTestSelectVM : ViewModelBase
    {
        private DcRecordDeliveryItem item;
        public RecordTestSelectVM(ModelObject model)
        {
            item = new PMSMainService.DcRecordDeliveryItem();
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
            MsgObject msg = new PMSTabletClient.MsgObject();

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
            msg.MsgModel = new ModelObject() { IsNew = true, Model = item };
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
            MsgObject msg = new PMSTabletClient.MsgObject();

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
            msg.MsgModel = new PMSTabletClient.ModelObject() { IsNew = true, Model = item };
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
        public RelayCommand Search { get; set; }
        public RelayCommand All { get; set; }
        public RelayCommand<DcRecordTest> Select { get; set; }

        public RelayCommand Empty { get; set; }
        public RelayCommand PageChanged { get; private set; }
        #endregion
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
