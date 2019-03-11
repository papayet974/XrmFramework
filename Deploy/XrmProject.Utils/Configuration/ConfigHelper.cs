﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deploy.Utils
{
    public static class ConfigHelper
    {
        public static XrmFrameworkSection GetSection()
        {
            return ConfigurationManager.GetSection("xrmFramework") as XrmFrameworkSection;
        }
        
        public static string GetEntitiesSolutionUniqueName()
        {
            return GetSection().EntitySolution.Name;
        }
    }
}
