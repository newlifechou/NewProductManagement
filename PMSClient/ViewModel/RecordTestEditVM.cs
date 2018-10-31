﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using PMSClient.MainService;
using System.Collections.ObjectModel;
using PMSClient.CheckLogic;



namespace PMSClient.ViewModel
{
    public class RecordTestEditVM : BaseViewModelEdit
    {
        public RecordTestEditVM()
        {
            InitializeBasic();

            GiveUp = new RelayCommand(GoBack);
            Save = new RelayCommand(ActionSave);
            Select = new RelayCommand(ActionSelect);
            SelectMisson = new RelayCommand(ActionSelectMisson);
            SelectDimensionActual = new RelayCommand(ActionSelectDimensionActual);
        }

        private void InitializeBasic()
        {
            States = new List<string>();
            PMSBasicDataService.SetListDS<PMSCommon.CommonState>(States);

            TestTypes = new List<string>();
            PMSBasicDataService.SetListDS<PMSCommon.TestType>(TestTypes);

            TestFollowUps = new List<string>();
            PMSBasicDataService.SetListDS<PMSCommon.TestFollowUps>(TestFollowUps);

            TestDefects = new List<string>();
            PMSBasicDataService.SetListDS<PMSCommon.TestDefectsTypes>(TestDefects);

            CustomerNames = new List<string>();
            PMSBasicDataService.SetListDS(BasicData.Customers, CustomerNames, i => i.CustomerName);
        }

        private void ActionSelectDimensionActual()
        {
            PMSHelper.ViewModels.RecordMachineSelect.SetRequestView(PMSViews.RecordTestEdit);
            NavigationService.GoTo(PMSViews.RecordMachineSelect);
        }

        public void SetNew()
        {
            IsNew = true;
            var model = new DcRecordTest();
            #region 初始化
            model.ID = Guid.NewGuid();
            model.CreateTime = DateTime.Now;
            model.PMINumber = "";
            model.FollowUps = "发货";
            model.Composition = "成分";
            model.ProductID = UsefulPackage.PMSTranslate.PlanLot();
            model.CompositionXRF = "暂无";
            model.Dimension = "要求尺寸";
            model.DimensionActual = "实际尺寸";
            model.PO = "PO";
            model.CompositionAbbr = "成分缩写";
            model.Customer = "客户信息";
            model.Creator = PMSHelper.CurrentSession.CurrentUser.UserName;
            model.TestType = PMSCommon.TestType.靶材.ToString();
            model.State = PMSCommon.CommonState.未录入.ToString();
            model.Weight = "0";
            model.Remark = "";
            model.Resistance = "0";
            model.Sample = "";
            model.CompositionXRF = "暂无";
            model.Density = "0";
            model.Defects = "无";
            model.OrderDate = DateTime.Now.AddDays(-30);
            model.FollowUps = PMSCommon.TestFollowUps.发货.ToString();
            #endregion
            CurrentRecordTest = model;
        }
        public void SetEdit(DcRecordTest model)
        {
            if (model != null)
            {
                IsNew = false;
                CurrentRecordTest = model;
            }
        }

        public void SetDimensionActual(DcRecordMachine model)
        {
            if (model != null)
            {
                CurrentRecordTest.DimensionActual = UsefulPackage.PMSTranslate.Dimension(model);
            }
        }

        public void SetDuplicate(DcRecordTest model)
        {
            if (model != null)
            {
                IsNew = true;
                model.ID = Guid.NewGuid();
                model.CreateTime = DateTime.Now;
                model.Creator = PMSHelper.CurrentSession.CurrentUser.UserName;
                model.State = PMSCommon.CommonState.未录入.ToString();
                CurrentRecordTest = model;
            }
        }

        public void SetBySelectMisson(DcOrder order)
        {
            if (order != null)
            {
                CurrentRecordTest.PMINumber = order.PMINumber;
                CurrentRecordTest.Composition = order.CompositionStandard;
                CurrentRecordTest.CompositionAbbr = order.CompositionAbbr;
                CurrentRecordTest.PO = order.PO;
                CurrentRecordTest.ProductID = "请手动输入";
                CurrentRecordTest.Customer = order.CustomerName;
                CurrentRecordTest.Dimension = order.Dimension;
                CurrentRecordTest.DimensionActual = order.Dimension;
                CurrentRecordTest.OrderDate = order.CreateTime;
            }
        }

        public void SetBySelect(DcPlanWithMisson plan)
        {
            if (plan != null)
            {
                CurrentRecordTest.PMINumber = plan.Misson.PMINumber;
                CurrentRecordTest.Composition = plan.Misson.CompositionStandard;
                CurrentRecordTest.CompositionAbbr = plan.Misson.CompositionAbbr;
                CurrentRecordTest.PO = plan.Misson.PO;
                CurrentRecordTest.ProductID = UsefulPackage.PMSTranslate.PlanLot(plan);
                CurrentRecordTest.Customer = plan.Misson.CustomerName;
                CurrentRecordTest.Dimension = plan.Misson.Dimension;
                CurrentRecordTest.DimensionActual = plan.Misson.Dimension;
                CurrentRecordTest.OrderDate = plan.Misson.CreateTime;
                //RaisePropertyChanged(nameof(CurrentRecordTest));
            }
        }

        private void ActionSelectMisson()
        {
            PMSHelper.ViewModels.MissonSelect.SetRequestView(PMSViews.RecordTestEdit);
            PMSHelper.ViewModels.MissonSelect.RefreshData();
            NavigationService.GoTo(PMSViews.MissonSelect);
        }

        private void ActionSelect()
        {
            PMSHelper.ViewModels.PlanSelect.SetRequestView(PMSViews.RecordTestEdit);
            PMSHelper.ViewModels.PlanSelect.RefreshData();
            NavigationService.GoTo(PMSViews.PlanSelect);
        }

        private static void GoBack()
        {
            NavigationService.GoTo(PMSViews.RecordTest);
        }

        private void ActionSave()
        {
            if (!PMSDialogService.ShowYesNo("请问", "仔细核对每项数据是否准确\r\n确定保存这条记录？"))
            {
                return;
            }

            string composition = CurrentRecordTest.CompositionXRF;
            //检测是否错误输入Si，S，P，B，C之类不可测试的元素
            if (composition.Contains("Si atm%")
                || composition.Contains("S atm%")
                || composition.Contains("P atm%")
                || composition.Contains("B atm%")
                || composition.Contains("C atm%")
                )
            {
                if (!PMSDialogService.ShowYesNo("请问", "成分误包含有Si，S，P，B，C,确定继续保存吗？"))
                {
                    return;
                }
            }

            //密度检查
            string abbr = CurrentRecordTest.CompositionAbbr;
            double density = 0;
            double.TryParse(CurrentRecordTest.Density, out density);
            if (!string.IsNullOrEmpty(abbr) && density != 0)
            {
                CheckResult msg = RecordTestCheckLogic.IsDensityOK(abbr, density);
                if (!msg.IsCheckOK)
                {
                    PMSDialogService.ShowWarning(msg.Message);
                }
            }



            if (CurrentRecordTest.State == "作废")
            {
                if (!PMSDialogService.ShowYesNo("请问", "确定作废这条记录？"))
                {
                    return;
                }
            }
            try
            {
                string uid = PMSHelper.CurrentSession.CurrentUser.UserName;
                var service = new RecordTestServiceClient();
                if (IsNew)
                {
                    service.AddRecordTestByUID(CurrentRecordTest, uid);
                }
                else
                {
                    service.UpdateRecordTestByUID(CurrentRecordTest, uid);
                }
                service.Close();
                PMSHelper.ViewModels.RecordTest.RefreshData();
                NavigationService.Status("保存成功，请刷新列表");
                GoBack();
            }
            catch (Exception ex)
            {
                PMSHelper.CurrentLog.Error(ex);
            }
        }
        public List<string> TestDefects { get; set; }
        public List<string> TestTypes { get; set; }
        public List<string> TestFollowUps { get; set; }
        public List<string> States { get; set; }
        public List<string> CustomerNames { get; set; }

        private DcRecordTest currentRecordTest;
        public DcRecordTest CurrentRecordTest
        {
            get { return currentRecordTest; }
            set
            {
                Set(nameof(CurrentRecordTest), ref currentRecordTest, value);
            }
        }
        public RelayCommand Select { get; set; }
        public RelayCommand SelectMisson { get; set; }

        public RelayCommand SelectDimensionActual { get; set; }
    }
}
