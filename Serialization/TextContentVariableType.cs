using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Rutland.PrintFileMaker.Serialization
{
    [Serializable]
    public class TextContentVariableType : VariableType
    {
        public TextContentVariableType()
        {
            base.category = "http://ns.adobe.com/Flows/1.0/";
            base.trait = "textcontent";
        }

        [XmlElement("p")]
        public string SerialNumber { get; set; }
    }
}
