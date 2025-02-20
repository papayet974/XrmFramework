﻿// Copyright (c) Christophe Gondouin (CGO Conseils). All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
using Model.Sdk;
using System;

namespace Model
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CrmMappingAttribute : Attribute
    {
        private CrmMappingAttribute(string attributeName, AttributeTypeCode attributeType)
        {
            AttributeName = attributeName;
            AttributeType = attributeType;
        }
        public CrmMappingAttribute(string attributeName)
        {
            AttributeName = attributeName;
        }

        public string AttributeName { get; private set; }

        protected AttributeTypeCode AttributeType { get; private set; }

        public bool FollowLink { get; set; }

        public bool IsValidForUpdate { get; set; } = true;

        public LookupAttributeInfo LookupInfo { get; set; }
    }

    public enum LookupAttributeInfo
    {
        None,
        Id,
        Name
    }
}