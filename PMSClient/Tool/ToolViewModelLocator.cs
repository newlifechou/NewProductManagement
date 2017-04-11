﻿using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSClient.Tool
{
    public class ToolViewModelLocator
    {
        public ToolViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MaterialNeedCalcualtionVM>();



        }
        public MaterialNeedCalcualtionVM MaterialNeedCalcualtion
        {
            get { return SimpleIoc.Default.GetInstance<MaterialNeedCalcualtionVM>(); }
        }





    }
}
