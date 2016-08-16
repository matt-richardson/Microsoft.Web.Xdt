using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Web.XmlTransform.Xml
{
    internal struct LineInfo
    {
        internal int lineNo;
        internal int linePos;

        public LineInfo(int lineNo, int linePos)
        {
            this.lineNo = lineNo;
            this.linePos = linePos;
        }

        public void Set(int lineNo, int linePos)
        {
            this.lineNo = lineNo;
            this.linePos = linePos;
        }
    }
}
