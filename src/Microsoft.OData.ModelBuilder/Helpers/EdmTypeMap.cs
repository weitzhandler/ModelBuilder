﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder.Config;

namespace Microsoft.OData.ModelBuilder.Helpers
{
    internal class EdmTypeMap
    {
        public EdmTypeMap(
            Dictionary<Type, IEdmType> edmTypes,
            Dictionary<PropertyInfo, IEdmProperty> edmProperties,
            Dictionary<IEdmProperty, QueryableRestrictions> edmPropertiesRestrictions,
            Dictionary<IEdmProperty, ModelBoundQuerySettings> edmPropertiesQuerySettings,
            Dictionary<IEdmStructuredType, ModelBoundQuerySettings> edmStructuredTypeQuerySettings,
            Dictionary<Enum, IEdmEnumMember> enumMembers,
            Dictionary<IEdmStructuredType, PropertyInfo> openTypes,
            Dictionary<IEdmStructuredType, PropertyInfo> instanceAnnotatableTypes)
        {
            EdmTypes = edmTypes;
            EdmProperties = edmProperties;
            EdmPropertiesRestrictions = edmPropertiesRestrictions;
            EdmPropertiesQuerySettings = edmPropertiesQuerySettings;
            EdmStructuredTypeQuerySettings = edmStructuredTypeQuerySettings;
            EnumMembers = enumMembers;
            OpenTypes = openTypes;
            InstanceAnnotatableTypes = instanceAnnotatableTypes;
        }

        public Dictionary<Type, IEdmType> EdmTypes { get; }

        public Dictionary<PropertyInfo, IEdmProperty> EdmProperties { get; }

        public Dictionary<IEdmProperty, QueryableRestrictions> EdmPropertiesRestrictions { get; }

        public Dictionary<IEdmProperty, ModelBoundQuerySettings> EdmPropertiesQuerySettings { get; }

        public Dictionary<IEdmStructuredType, ModelBoundQuerySettings> EdmStructuredTypeQuerySettings { get; }

        public Dictionary<Enum, IEdmEnumMember> EnumMembers { get; }

        public Dictionary<IEdmStructuredType, PropertyInfo> OpenTypes { get; }

        public Dictionary<IEdmStructuredType, PropertyInfo> InstanceAnnotatableTypes { get; }
    }
}
