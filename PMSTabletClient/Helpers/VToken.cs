﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSTabletClient
{
    /// <summary>
    /// 导航token
    /// 用来表示要显示的视图的token
    /// </summary>
    public enum VToken
    {
        Navigation,
        LogIn,
        Order,
        OrderEdit,
        OrderRefresh,
        OrderSelect,
        OrderCheck,
        OrderCheckRefresh,
        OrderCheckEdit,
        Misson,
        MissonRefresh,
        Plan,
        PlanEdit,
        PlanSelectForTest,
        RecordTest,
        RecordTestEdit,
        RecordTestSelect,
        RecordDelivery,
        RecordDeliveryEdit,
        RecordDeliveryItem,
        RecordDeliveryItemEdit,
        RecordMilling,
        RecordMillingEdit,
        RecordVHP,
        RecordVHPEdit,
        RecordTakeOut,
        RecordTakeOutEdit,
        RecordMachine,
        RecordMachineEdit,
        RecordBonding,
        RecordBondingEdit,
        MaterialOrder,
        MaterialOrderEdit,
        MaterialOrderItemEdit,
        MaterialNeed,
        MaterialNeedEdit,
        MaterialNeedSelect,
        MaterialInventory,
        MaterialInventoryEdit,
        MaterialNeedRefresh,
        MaterialOrderRefresh,
        RecordTestRefresh,
        RecordDeliveryRefresh,
        PlanSelectForVHP,
        RecordVHPRefresh,
        RecordVHPQuickEdit,
        SetRecordVHPQuickEditSelectIndex,
        MaterialOrderItemRefresh,
        RecordDeliveryItemRefresh
    }
}
