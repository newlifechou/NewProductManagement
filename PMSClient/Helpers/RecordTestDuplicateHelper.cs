﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMSClient.MainService;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace PMSClient.Helpers
{
    public class RecordTestDuplicateHelper
    {

        public void Run(DcRecordTest model, int quantity = 1)
        {
            string productid = model.ProductID;
            string pattern_230 = @"(\d{6}-\w)\w-\d{1}";
            var result = Regex.Match(productid, pattern_230);
            if (result.Success)
            {
                string baseStr = result.Groups[1].ToString();
                if (quantity == 1)
                {
                    SaveNew(model, $"{baseStr}A-2");
                }
                if (quantity == 2)
                {
                    SaveNew(model, $"{baseStr}A-2");
                    SaveNew(model, $"{baseStr}B-1");
                }
                if (quantity == 3)
                {
                    SaveNew(model, $"{baseStr}A-2");
                    SaveNew(model, $"{baseStr}B-1");
                    SaveNew(model, $"{baseStr}B-2");
                }
            }
            else
            {
                for (int i = 0; i < quantity; i++)
                {
                    SaveNew(model, productid.Substring(0, 9) + (i + 2));
                }
            }

        }

        public void SaveNew(DcRecordTest model, string newproductid)
        {
            using (var s = new RecordTestServiceClient())
            {
                DcRecordTest new_model = GetCopyWithNewID(model, newproductid);
                s.AddRecordTestByUID(new_model, PMSHelper.CurrentSession.CurrentUser.UserName);
            }
        }

        public DcRecordTest GetCopyWithNewID(DcRecordTest test, string productid)
        {
            string json = JsonConvert.SerializeObject(test);
            DcRecordTest model = JsonConvert.DeserializeObject<DcRecordTest>(json);
            model.ID = Guid.NewGuid();
            model.CreateTime = DateTime.Now;
            model.ProductID = productid;
            model.Creator = PMSHelper.CurrentSession.CurrentUser.UserName;
            return model;
        }
    }
}