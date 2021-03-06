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

namespace PMSClient.ViewModel
{
    public class MaterialInventoryOutVM : BaseViewModelPage
    {
        public MaterialInventoryOutVM()
        {
            InitializeProperties();
            InitializeCommands();
            DoAllGetJob();
        }
        /// <summary>
        /// 综合查询
        /// </summary>
        /// <param name="pminumber"></param>
        public void SetSearch(string pminumber)
        {
            SearchComposition = "";
            SearchMaterialLot = "";
            SearchPMINumber = pminumber;
            SearchReceiver = "";
            SetPageParametersWhenConditionChange();
        }

        public void RefreshData()
        {
            DoAllGetJob();
        }

        private void InitializeProperties()
        {
            searchComposition = searchMaterialLot = searchPMINumber = searchReceiver = "";
            MaterialInventoryOuts = new ObservableCollection<DcMaterialInventoryOut>();
            NewMaterialUsedList = new ObservableCollection<DcRecordMilling>();
        }
        private void InitializeCommands()
        {
            PageChanged = new RelayCommand(ActionPaging);
            Search = new RelayCommand(ActionSearch, CanSearch);
            All = new RelayCommand(ActionAll);

            Add = new RelayCommand(ActionAdd, CanAdd);
            Edit = new RelayCommand<DcMaterialInventoryOut>(ActionEdit, CanEdit);

            GoToMaterialInventoryIn = new RelayCommand(() => NavigationService.GoTo(PMSViews.MaterialInventoryIn),
                () => PMSHelper.CurrentSession.IsAuthorized(PMSAccess.ReadMaterialInventoryOut));

            CheckMaterial = new RelayCommand<DcRecordMilling>(ActionCheckMaterial);
            RefreshRecordMillingByNewMaterial = new RelayCommand(ActionRefreshRecordMillingByNewMaterial);

            Output = new RelayCommand(ActionOutput);
        }

        private void ActionOutput()
        {
            if (!PMSDialogService.ShowYesNo("请问", "确定要导出全部数据吗？"))
            {
                return;
            }
            try
            {
                var excel = new ExcelOutputHelper.ExcelOutputMaterialOut();
                excel.Intialize("原料出库导出记录", "原料出库");
                excel.Output();
            }
            catch (Exception ex)
            {
                PMSHelper.CurrentLog.Error(ex);
            }
        }

        private void ActionRefreshRecordMillingByNewMaterial()
        {
            GetNewMaterialUsed();
        }

        /// <summary>
        /// 检查新料使用情况
        /// </summary>
        /// <param name="model"></param>
        private void ActionCheckMaterial(DcRecordMilling model)
        {
            if (model == null)
                return;
            try
            {
                int inCount = 0, outCount = 0;
                using (var service = new MaterialInventoryServiceClient())
                {
                    inCount = service.CheckMaterialIn(model.PMINumber);
                    outCount = service.CheckMaterialOut(model.PMINumber);
                }
                string msg = $"{model.PMINumber}-入库数据中找到{inCount}条，出库数据中找到{outCount}条";
                PMSDialogService.Show(msg);
            }
            catch (Exception ex)
            {
                PMSHelper.CurrentLog.Error(ex);
            }
        }

        private bool CanEdit(DcMaterialInventoryOut arg)
        {
            return PMSHelper.CurrentSession.IsAuthorized(PMSAccess.EditMaterialInventoryOut);
        }

        private bool CanAdd()
        {
            return PMSHelper.CurrentSession.IsAuthorized(PMSAccess.EditMaterialInventoryOut);
        }

        private void ActionEdit(DcMaterialInventoryOut model)
        {
            if (model != null)
            {
                PMSHelper.ViewModels.MaterialInventoryOutEdit.SetEdit(model);
                NavigationService.GoTo(PMSViews.MaterialInventoryOutEdit);
            }
        }

        private void ActionAdd()
        {
            PMSHelper.ViewModels.MaterialInventoryOutEdit.SetNew();
            NavigationService.GoTo(PMSViews.MaterialInventoryOutEdit);
        }

        private bool CanSearch()
        {
            return !(string.IsNullOrEmpty(SearchComposition) && string.IsNullOrEmpty(SearchMaterialLot)
                && string.IsNullOrEmpty(SearchPMINumber) && string.IsNullOrEmpty(SearchReceiver));
        }

        private void ActionAll()
        {
            SearchComposition = SearchMaterialLot = SearchPMINumber = SearchReceiver = "";
            DoAllGetJob();
        }

        private void ActionSearch()
        {
            DoAllGetJob();
        }

        private void DoAllGetJob()
        {
            SetPageParametersWhenConditionChange();
            GetNewMaterialUsed();
        }

        /// <summary>
        /// 获取新出库的材料
        /// </summary>
        private void GetNewMaterialUsed()
        {
            try
            {
                using (var service = new RecordMillingServiceClient())
                {
                    string materialType = PMSCommon.CustomData.MaterialTypes[0];
                    int take = 20;
                    var tempStored = service.GetRecordMillingByMaterialType(materialType, take);
                    NewMaterialUsedList.Clear();
                    tempStored.ToList().ForEach(i => NewMaterialUsedList.Add(i));
                }
            }
            catch (Exception ex)
            {
                PMSHelper.CurrentLog.Error(ex);
            }
        }

        private void SetPageParametersWhenConditionChange()
        {
            PageIndex = 1;
            PageSize = 30;
            var service = new MaterialInventoryServiceClient();
            RecordCount = service.GetMaterialInventoryOutCountBySearch(SearchReceiver, SearchComposition,
                SearchMaterialLot, SearchPMINumber);
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
            var service = new MaterialInventoryServiceClient();
            var result = service.GetMaterialInventoryOutsBySearch(skip, take, SearchReceiver, SearchComposition,
                SearchMaterialLot, SearchPMINumber);
            service.Close();
            MaterialInventoryOuts.Clear();
            result.ToList().ForEach(o => MaterialInventoryOuts.Add(o));
        }

        #region Proeperties
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
        private string searchMaterialLot;
        public string SearchMaterialLot
        {
            get { return searchMaterialLot; }
            set { searchMaterialLot = value; RaisePropertyChanged(nameof(SearchMaterialLot)); }
        }

        private string searchReceiver;
        public string SearchReceiver
        {
            get { return searchReceiver; }
            set { searchReceiver = value; RaisePropertyChanged(nameof(SearchReceiver)); }
        }

        private string searchPMINumber;
        public string SearchPMINumber
        {
            get { return searchPMINumber; }
            set { searchPMINumber = value; RaisePropertyChanged(nameof(SearchPMINumber)); }
        }


        public ObservableCollection<DcMaterialInventoryOut> MaterialInventoryOuts { get; set; }

        public ObservableCollection<DcRecordMilling> NewMaterialUsedList { get; set; }

        #endregion

        #region Commands
        public RelayCommand Add { get; private set; }
        public RelayCommand<DcMaterialInventoryOut> Edit { get; private set; }

        public RelayCommand GoToMaterialInventoryIn { get; set; }


        public RelayCommand<DcRecordMilling> CheckMaterial { get; set; }

        public RelayCommand RefreshRecordMillingByNewMaterial { get; set; }

        public RelayCommand Output { get; set; }
        #endregion



    }
}
