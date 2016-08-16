using System.Collections.Generic;
using System.Xml;

namespace Microsoft.Web.XmlTransform.Xml
{
    internal class XmlAsyncCheckReaderWithNs : XmlAsyncCheckReader, IXmlNamespaceResolver
    {
        private readonly IXmlNamespaceResolver _readerAsIXmlNamespaceResolver;

        public XmlAsyncCheckReaderWithNs(XmlReader reader)
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