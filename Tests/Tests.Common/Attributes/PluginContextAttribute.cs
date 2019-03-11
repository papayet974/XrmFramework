﻿using System;

namespace Plugins.Tests
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class PluginContextAttribute : Attribute
    {
        public PluginContextAttribute(Stages stage, Messages message, Modes mode, string entityName)
        {
            Message = message;
            Stage = stage;
            Mode = mode;
            EntityName = entityName;
        }

        public Messages Message { get; set; }
        public Stages Stage { get; set; }
        public Modes Mode { get; set; }
        public string EntityName { get; set; }
    }
}
