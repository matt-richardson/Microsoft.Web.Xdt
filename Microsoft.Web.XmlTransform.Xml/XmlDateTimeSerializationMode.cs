﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.Web.XmlTransform.Xml
{
    // Options for serializing and deserializing DateTime
    public enum XmlDateTimeSerializationMode
    {
        Local,
        Utc,
        Unspecified,
        RoundtripKind,
    }
}
