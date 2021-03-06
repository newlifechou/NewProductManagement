﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMSDAL
{
    /// <summary>
    /// 订单
    /// </summary>
    public class PMSOrderHistory
    {
        //基本信息
        public Guid ID { get; set; }
        public string CustomerName { get; set; }
        public string PO { get; set; }
        public string PMINumber { get; set; }

        public string CompositionStandard { get; set; }//成分规范表示
        public string CompositionOriginal { get; set; }//成分原始表示
        public string CompositionAbbr { get; set; }
        public string ProductType { get; set; }
        public string Purity { get; set; }

        public double Quantity { get; set; }
        public string QuantityUnit { get; set; }

        public string Dimension { get; set; }//尺寸标准表示
        public string DimensionDetails { get; set; }//尺寸细节

        public string SampleNeed { get; set; }//客户是否需要样品

        public string Drawing { get; set; }//图纸
        public string SampleForAnlysis { get; set; }//PMI是否需要取样分析
        public string SampleNeedRemark { get; set; }//是否需要样品备注
        public string SampleForAnlysisRemark { get; set; }//PMI是否需要取样分析备注
        public string ShipTo { get; set; }//发货目的地
        public string WithBackingPlate { get; set; }//是否配对应背板，填写背板尺寸或者名称
        public string PlateDrawing { get; set; }//背板图纸
        public string SpecialRequirement { get; set; }

        public DateTime DeadLine { get; set; }

        public string MinimumAcceptDefect { get; set; }//密度要求，加工要求，表面洁净度，多大的缺口可以接受，多大的裂缝可以接受，表面有花纹是否可以接受，表面有坑是否可以接受
        public string Remark { get; set; }

        //热压指数
        public double ProductionIndex { get; set; }
        public double MaterialIndex { get; set; }

        //状态部分
        public string Priority { get; set; }//紧急，一般，不着急
        public string State { get; set; }//正在生产，生产完成，发货完成，取消，暂停
        public string StateRemark { get; set; }//当前状态的原因，主要给取消和暂停用


        //创建者和审核部分
        public DateTime CreateTime { get; set; }
        public string Creator { get; set; }
        public DateTime ReviewTime { get; set; }
        public string Reviewer { get; set; }
        //决策部分
        public string PolicyType { get; set; }//热压，代工，库存，其他,只有热压订单才会进入任务
        public DateTime FinishTime { get; set; }

        public string PartNumber { get; set; }
        public string SecondMachineDimension { get; set; }
        public string SecondMachineDetails { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public string OrderRemark { get; set; }

        public string BondingRequirement { get; set; }

        public string LaserNeed { get; set; }

        //操作者和操作时间
        [Key]
        public Guid HistoryID { get; set; }
        public string Operator { get; set; }
        public DateTime OperateTime { get; set; }
    }
}
