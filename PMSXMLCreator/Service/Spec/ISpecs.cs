﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSXMLCreator.Service
{
    public interface ISpecs
    {
        SpecModel GetShortName(string key);
        string SpecName { get; }
    }
}
