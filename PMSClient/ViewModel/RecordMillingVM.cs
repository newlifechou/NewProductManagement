﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;
using PMSClient.MainService;



namespace PMSClient.ViewModel
{
    public class RecordMillingVM : BaseViewModelPage
    {
        public RecordMillingVM()
        {

            searchVHPPlanLot = searchComposition = "";

            RecordMillings = new ObservableCollection<DcRecordMilling>();
            SetPageParametersWhenConditionChange();
            InitializeCommands();
        }

        public void RefreshData()
        {
            SetPageParametersWhenConditionChange();
        }
        private void InitializeCommands()
        {
            PageChanged = new RelayCommand(ActionPaging);
            Add = new RelayCommand(ActionAdd, CanAdd);
            Edit = new RelayCommand<DcRecordMilling>(ActionEdit, CanEdit);
            Search = new RelayCommand(ActionSearch);
            All = new RelayCommand(ActionAll);
            SelectionChanged = new RelayCommand<DcRecordMilling>(ActionSelectionChanged);
            Label = new RelayCommand<DcRecordMilling>(ActionLabel);
            Calculator = new RelayCommand(ActionCalculator);
            QuickAdd = new RelayCommand(ActionQuickAdd, CanQuickAdd);
            Output = new RelayCommand(ActionOutput);
        }

        private void ActionOutput()
        {

        }

        private bool CanQuickAdd()
        {
            return PMSHelper.CurrentSession.IsAuthorized(PMSAccess.EditRecordMilling);
        }

        private void ActionQuickAdd()
        {
            PMSHelper.ViewModels.PlanSelect.SetRequestView(PMSViews.RecordMilling);
            PMSHelper.ViewModels.PlanSelect.RefreshData();
            NavigationService.GoTo(PMSViews.PlanSelect);
        }

        private void ActionLabel(DcRecordMilling model)
        {
            if (model != null)
            {

                var sb = new StringBuilder();
                sb.AppendLine("粉末");
                sb.AppendLine(model.Composition);
                sb.AppendLine(model.PMINumber);
                sb.AppendLine(model.VHPPlanLot);
                sb.Append("粒径");
                sb.AppendLine(model.GrainSize);
                sb.AppendLine("重量:");

                var mainContent = sb.ToString();

                //var pageTitle = "热压毛坯标签打印输出";
                //var tips = @"点击打开模板按钮，粘贴不同内容到模板合适位置，热压编号是自动生成的，可能不正确，请再自行修改，然后打印标签";
                //var template = "毛坯标签";
                //var helpimage = "productionlabel.png";
                //PMSHelper.ToolViewModels.LabelOutPut.SetAllParameters(PMSViews.RecordMilling, pageTitle,
                //    tips, template, mainContent, helpimage);
                //NavigationService.GoTo(PMSViews.LabelOutPut);

                //2017-12-18
                PMSClient.Tool.LabelCopyWindow lcw = new Tool.LabelCopyWindow();
                lcw.LabelInformation = mainContent;
                lcw.ShowDialog();
            }
        }

        private void ActionCalculator()
        {
            PMSHelper.ToolViewModels.MaterialNeedCalcualtion.SetRequestView(PMSViews.RecordMillingEdit);
            NavigationService.GoTo(PMSViews.MaterialNeedCalcuationTool);
        }

        private void ActionSelectionChanged(DcRecordMilling model)
        {
            if (model != null)
            {
                CurrentRecordMilling = model;
            }
        }

        private bool CanEdit(DcRecordMilling arg)
        {
            return PMSHelper.CurrentSession.IsAuthorized(PMSAccess.EditRecordMilling);
        }

        private bool CanAdd()
        {
            return PMSHelper.CurrentSession.IsAuthorized(PMSAccess.EditRecordMilling);
        }

        private void ActionAll()
        {
            SearchVHPPlanLot = SearchComposition = "";
            SetPageParametersWhenConditionChange();
        }

        private void ActionSearch()
        {
            SetPageParametersWhenConditionChange();
        }

        private void ActionEdit(DcRecordMilling model)
        {
            if (model != null)
            {
                PMSHelper.ViewModels.RecordMillingEdit.SetEdit(model);
                NavigationService.GoTo(PMSViews.RecordMillingEdit);
            }
        }

        private void ActionAdd()
        {
            PMSHelper.ViewModels.RecordMillingEdit.SetNew();
            NavigationService.GoTo(PMSViews.RecordMillingEdit);
        }

        private void SetPageParametersWhenConditionChange()
        {
            PageIndex = 1;
            PageSize = 20;
            var service = new RecordMillingServiceClient();
            RecordCount = service.GetRecordMillingCountByVHPPlanLot(SearchVHPPlanLot, SearchComposition);
            service.Close();
            ActionPaging();
        }
        private void ActionPaging()
        {

            int skip, take = 0;
            skip = (PageIndex - 1) * PageSize;
            take = PageSize;
            var service = new RecordMillingServiceClient();
            var models = service.GetRecordMillingsByVHPPlanLot(skip, take, SearchVHPPlanLot, SearchComposition);
            service.Close();
            RecordMillings.Clear();
            models.ToList().ForEach(o => RecordMillings.Add(o));

            CurrentRecordMilling = RecordMillings.FirstOrDefault();
        }

        private string searchVHPPlanLot;
        public string SearchVHPPlanLot
        {
            get { return searchVHPPlanLot; }
            set { searchVHPPlanLot = value; RaisePropertyChanged(nameof(SearchVHPPlanLot)); }
        }

        private string searchComposition;
        public string SearchComposition
        {
            get { return searchComposition; }
            set { searchComposition = value; RaisePropertyChanged(nameof(SearchComposition)); }
        }
        #region DerivedPart
        private DcRecordMilling currentRecordMilling;

        public DcRecordMilling CurrentRecordMilling
        {
            get { return currentRecordMilling; }
            set { currentRecordMilling = value; RaisePropertyChanged(nameof(CurrentRecordMilling)); }
        }

        public ObservableCollection<DcRecordMilling> RecordMillings { get; set; }

        public RelayCommand Add { get; set; }
        public RelayCommand<DcRecordMilling> Edit { get; set; }

        public RelayCommand<DcRecordMilling> SelectionChanged { get; set; }
        public RelayCommand Calculator { get; set; }

        public RelayCommand<DcRecordMilling> Label { get; set; }

        public RelayCommand QuickAdd { get; set; }

        public RelayCommand Output { get; set; }
        #endregion
    }
}
