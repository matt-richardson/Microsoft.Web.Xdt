// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Xml;

namespace Microsoft.Web.XmlTransform.Xml
{
    internal class XmlAsyncCheckReaderWithLineInfoNS : XmlAsyncCheckReaderWithLineInfo, IXmlNamespaceResolver
    {
        private readonly IXmlNamespaceResolver _readerAsIXmlNamespaceResolver;

        public XmlAsyncCheckReaderWithLineInfoNS(XmlReader reader)
            : base(reader)
        {
            _readerAsIXmlNamespaceResolver = (IXmlNamespaceResolver)reader;
        }

        #region IXmlNamespaceResolver members
        IDictionary<string, string> IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope)
        {
            return _readerAsIXmlNamespaceResolver.GetNamespacesInScope(scope);
        }

        string IXmlNamespaceResolver.LookupNamespace(string prefix)
        {
            return _readerAsIXmlNamespaceResolver.LookupNamespace(prefix);
        }

        string IXmlNamespaceResolver.LookupPrefix(string namespaceName)
        {
            return _readerAsIXmlNamespaceResolver.LookupPrefix(namespaceName);
        }
        #endregion
    }
}
