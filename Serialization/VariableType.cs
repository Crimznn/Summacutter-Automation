using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Rutland.PrintFileMaker.Serialization
{
    public class VariableType
    {
        [XmlAttribute]
        public string varName { get; set; }

        [XmlAttribute]
        public string trait { get; set; }

        [XmlAttribute]
        public string category { get; set; }
                

        public VariableType()
        {
            this.category = "http://ns.adobe.com/Variables/1.0";
            this.trait = "fileref";
        }

    }
}
