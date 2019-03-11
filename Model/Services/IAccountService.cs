﻿using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;

namespace Plugins
{
    /// <summary>
    /// All Services related to Account 
    /// </summary>
    public interface IAccountService : IService
    {
        ICollection<EntityReference> GetSubContactRefs(EntityReference accountRef);
    }
}
