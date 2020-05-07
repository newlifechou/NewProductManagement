﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMSClient.OutputService;

namespace PMSClient.ExcelOutputHelper
{
    /// <summary>
    /// 用来输出原料订单项目
    /// </summary>
    public class ExcelConsumableInventory:ExcelOutputBasePage
    {
        public ExcelConsumableInventory()
        {

        }
        public override void Output()
        {
            //ResetParameters();
            using (var service = new OutputServiceClient())
            {
                recordCount = service.GetConsumableInventoryByYearMonthCount();
                pageCount = GetPageCount();

                NPOIHelper helper = new NPOIHelper();
                helper.CreateNew(sheetName);

                //插入标题行
                string[] titles = { "状态", "创建时间", "创建者", "类别", "品名", "规格", "细节", "数量", "单位", "级别", "存储位置", "负责人", "最大预警量", "最小预警量", "出入历史", "盘点历史", "最后更新时间", "备注" };

                helper.AddRowTitle(titles);

                //插入数据行
                int rowIndex = 1;
                int columnIndex = 0;
                int s = 0, t = 0;
                while (pageIndex < pageCount)
                {
                    s = pageIndex * pageSize;
                    t = pageSize;
                    var pagedData = service.GetConsumableInventoryByYearMonth(s, t);
                    foreach (var item in pagedData)
                    {
                        columnIndex = 0;
                        helper.CreateRow(rowIndex);
                        helper.CreateAndSetCell(columnIndex++, item.State);
                        helper.CreateAndSetCell(columnIndex++, item.CreateTime.ToString());
                        helper.CreateAndSetCell(columnIndex++, item.Creator);
                        helper.CreateAndSetCell(columnIndex++, item.Category);
                        helper.CreateAndSetCell(columnIndex++, item.ItemName);
                        helper.CreateAndSetCell(columnIndex++, item.Specification);
                        helper.CreateAndSetCell(columnIndex++, item.Details);
                        helper.CreateAndSetCell(columnIndex++, item.Quantity);
                        helper.CreateAndSetCell(columnIndex++, item.QuantityUnit);
                        helper.CreateAndSetCell(columnIndex++, item.Grade);
                        helper.CreateAndSetCell(columnIndex++, item.StorePosition);
                        helper.CreateAndSetCell(columnIndex++, item.PersonInCharge);
                        helper.CreateAndSetCell(columnIndex++, item.MaxWarningQuantity);
                        helper.CreateAndSetCell(columnIndex++, item.MinWarningQuantity);
                        helper.CreateAndSetCell(columnIndex++, item.History);
                        helper.CreateAndSetCell(columnIndex++, item.CountHistory);
                        helper.CreateAndSetCell(columnIndex++, item.LastUpdateTime.ToString());
                        helper.CreateAndSetCell(columnIndex++, item.Remark);
                        rowIndex++;
                    }
                    pageIndex++;
                }

                helper.Save(excelFileName);

                PMSDialogService.Show($"{excelFileName}创建完毕,请到桌面查看");
                CheckOpenAfterCreate();

            }
        }
    }
}
