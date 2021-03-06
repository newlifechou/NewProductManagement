﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMSClient.Components.CscanImageProcess;
using PMSClient.DataProcess.ScanInput;
using PMSClient.MainService;
using PMSClient.ReportsHelper;
using PMSClient.ReportsHelperNew;

namespace PMSClient.DataProcess.QuickReport
{
    public class ProcessReport : ProcessBase
    {
        public ProcessReport()
        {
            CurrentReportType = "TEST";
            CurrentCSCANType = ImageType.Bonding;
        }
        public string CurrentReportType { get; set; }
        public ImageType CurrentCSCANType { get; set; }


        public override void Check(Action<double> DoSomething)
        {
            try
            {
                ReSet();
                double progressValue = 0;
                double count = 0;
                foreach (var item in Lots)
                {
                    //默认有效，多次否决
                    CheckIsStandard(item);
                    CheckInRecordTest(item);

                    count++;
                    progressValue = count * 100 / Lots.Count;
                    if (DoSomething != null)
                    {
                        DoSomething(progressValue);
                        System.Threading.Thread.Sleep(50);
                    }
                }
            }
            catch (Exception ex)
            {
                PMSHelper.CurrentLog.Error(ex);
            }
        }
        public override void Process(Action<double> DoSomething)
        {
            try
            {
                ReSet();
                double progressValue = 0;
                double count = 0;
                foreach (var item in Lots)
                {
                    //检查
                    CheckIsStandard(item);
                    CheckInRecordTest(item);

                    //有效继续
                    if (item.IsValid)
                    {
                        DcRecordTest model = null;

                        using (var service = new RecordTestServiceClient())
                        {
                            model = service.GetRecordTestByProductID(item.Lot).FirstOrDefault();
                        }

                        if (model != null)
                        {
                            #region 生成报告

                            switch (CurrentReportType)
                            {
                                case "COA":
                                    var report1 = new WordCOANew();
                                    report1.SetModel(model);
                                    report1.Output();
                                    break;
                                case "COA-BL":
                                    var report2 = new WordCOABridgeLineNew();
                                    report2.SetModel(model);
                                    report2.Output();
                                    break;
                                case "TEST":
                                    var report3 = new WordRecordTest();
                                    report3.SetModel(model);
                                    report3.Output();
                                    break;
                                case "COA200324":
                                    var fileName4 = ReportsHelperNew.COAHelper.GetCOAFileName(model);
                                    var report4 = new ReportCOA();
                                    report4.SetParameters(model, CurrentCSCANType, false);
                                    report4.Intialize(fileName4);
                                    report4.Output();
                                    break;
                                case "COA200324-BL":
                                    var fileName5 = ReportsHelperNew.COAHelper.GetCOAFileName(model, "BL");
                                    var report5 = new ReportCOABridgeLine();
                                    report5.SetParameters(model, CurrentCSCANType, false);
                                    report5.Intialize(fileName5);
                                    report5.Output();
                                    break;
                                default:
                                    break;
                            }

                            item.HasProcessed = true;
                            #endregion
                        }

                    }
                    count++;
                    progressValue = count * 100 / Lots.Count;
                    if (DoSomething != null)
                    {
                        DoSomething(progressValue);
                        System.Threading.Thread.Sleep(50);
                    }


                }
            }
            catch (Exception ex)
            {
                PMSHelper.CurrentLog.Error(ex);
            }
        }

        private void CheckInRecordTest(LotModel item)
        {
            if (item.IsValid)
            {
                using (var service = new RecordTestServiceClient())
                {
                    //这里增加一个服务？
                    var test = service.GetRecordTestByProductID(item.Lot);
                    if (test != null)
                    {
                        int count = test.Count();
                        if (count == 0)
                        {
                            item.IsValid = false;
                            item.AppendMessage("[测试]记录中不存在");
                        }
                        if (test.FirstOrDefault().State != PMSCommon.CommonState.已核验.ToString())
                        {
                            item.IsValid = false;
                            item.AppendMessage("此[测试]记录中尚未核验");
                        }
                    }

                }
            }
        }
    }
}
