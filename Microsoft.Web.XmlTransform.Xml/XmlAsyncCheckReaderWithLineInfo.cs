using System.Xml;

namespace Microsoft.Web.XmlTransform.Xml
{
    internal class XmlAsyncCheckReaderWithLineInfo : XmlAsyncCheckReader, IXmlLineInfo
    {
        private readonly IXmlLineInfo _readerAsIXmlLineInfo;

        public XmlAsyncCheckReaderWithLineInfo(XmlReader reader)
            : base(reader)
        {
            _readerAsIXmlLineInfo = (IXmlLineInfo)reader;
        }

        #region IXmlLineInfo members
        public virtual bool HasLineInfo()
        {
            return _readerAsIXmlLineInfo.HasLineInfo();
        }

        public virtual int LineNumber
        {
            get
            {
                return _readerAsIXmlLineInfo.LineNumber;
            }
        }

        public virtual int LinePosition
        {
            get
            {
                return _readerAsIXmlLineInfo.LinePosition;
            }
        }
        #endregion
    }
}