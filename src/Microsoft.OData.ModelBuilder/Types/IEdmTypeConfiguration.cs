﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.OData.Edm;

namespace Microsoft.OData.ModelBuilder
{
    /// <summary>
    /// Represents an EdmType which is associated with CLR type
    /// </summary>
    public interface IEdmTypeConfiguration
    {
        /// <summary>
        /// The CLR type associated with the EdmType.
        /// </summary>
        Type ClrType { get; }

        /// <summary>
        /// The fullname (including namespace) of the EdmType.
        /// </summary>
        string FullName { get; }

        /// <summary>
        /// The namespace of the EdmType.
        /// </summary>
        [SuppressMessage("Naming", "CA1716:Identifiers should not match keywords", Justification = "<Pending>")]
        string Namespace { get; }

        /// <summary>
        /// The name of the EdmType.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The kind of the EdmType.
        /// Examples include EntityType, ComplexType, PrimitiveType, CollectionType, EnumType.
        /// </summary>
        EdmTypeKind Kind { get; }

        /// <summary>
        /// The ODataModelBuilder used to create this IEdmType.
        /// </summary>
        ODataModelBuilder ModelBuilder { get; }
    }
}
