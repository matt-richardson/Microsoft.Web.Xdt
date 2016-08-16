using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Web.XmlTransform.Xml
{
    //
    // IDtdDefaultAttributeInfo interface
    //
    /// <summary>
    /// Exposes information about a default attribute 
    /// declared in a DTD that XmlReader need in order to be able to add 
    /// this attribute to the XML document (it is not present already) 
    /// or correctly normalize the attribute value according to its data types.
    /// </summary>
    internal interface IDtdDefaultAttributeInfo : IDtdAttributeInfo
    {
        /// <summary>
        /// The expanded default value of the attribute
        /// the consumer assumes that all entity references
        /// were already resolved in the value and that the value
        /// is correctly normalized.
        /// </summary>
        string DefaultValueExpanded { get; }
        /// <summary>
        /// The typed default value of the attribute.
        /// </summary>
        object DefaultValueTyped { get; }        /// <summary>
                                                 /// The line number of the default value (in the DTD)
                                                 /// </summary>
        int ValueLineNumber { get; }
        /// <summary>
        /// The line position of the default value (in the DTD)
        /// </summary>
        int ValueLinePosition { get; }
    }
}
