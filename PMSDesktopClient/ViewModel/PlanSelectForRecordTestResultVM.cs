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
    public class PlanSelectForRecordTestResultVM : PlanSelectBase
    {
        private DcRecordTestResult testresult;

        public PlanSelectForRecordTestResultVM()
        {
            testresult = new PMSMainService.DcRecordTestResult();
            testresult.ID = Guid.NewGuid();
            testresult.CreateTime = DateTime.Now;
            testresult.Creator = (App.Current as App).CurrentUser.UserName;
            testresult.TestType = PMSCommon.TestType.Product.ToString();
            testresult.State = "Checked";
            testresult.Weight = "0";
            testresult.Remark = "";
            testresult.Resistance = "";
            testresult.Sample = "";
            testresult.CompositionXRF = "";
            testresult.Density = "0";

            IntitializeCommands();
        }


        private void ActionSelect(DcMissonWithPlan obj)
        {
            testresult.Composition = obj.CompositionStandard;
            testresult.CompositionAbbr = obj.CompositoinAbbr;
            testresult.Customer = obj.CustomerName;
            testresult.Dimension = obj.Dimension;
            testresult.ProductID = obj.PlanDate.ToString("yyMMdd") + "-" + obj.VHPDeviceCode + "-" + 1;
            testresult.PO = obj.PO;
            testresult.DimensionActual = testresult.Dimension;

            MsgObject msg = new MsgObject();
            msg.MsgToken = VToken.RecordTestResultEdit;
            msg.MsgModel = new ModelObject() { IsNew = true, Model = testresult };
            NavigationService.GoTo(msg);
        }


        private void IntitializeCommands()
        {
            GiveUp = new RelayCommand(() => NavigationService.GoTo(new MsgObject() { MsgToken=VToken.RecordTestResult}));
            Select = new RelayCommand<PMSMainService.DcMissonWithPlan>(ActionSelect);
        }

    }
}