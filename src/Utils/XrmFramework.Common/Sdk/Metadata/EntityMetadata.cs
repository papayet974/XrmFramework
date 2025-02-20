﻿// Copyright (c) Christophe Gondouin (CGO Conseils). All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Model.Sdk.Metadata
{
    [DataContract]
    public class EntityMetadata
    {
        [DataMember(Name = "en")]
        public string EntityName { get; set; }

        [DataMember(Name = "fn")]
        public string FileName { get; set; }

        [DataMember(Name = "s")]
        public bool IsSelected { get; set; }
        
        [DataMember(Name = "ecn")]
        public string EntityCollectionName { get; set; }

        [DataMember(Name = "attributes")]
        public IList<AttributeMetadata> Attributes { get; set; } = new List<AttributeMetadata>();

    }
}
