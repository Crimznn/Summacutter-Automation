using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Rutland.PrintFileMaker.Serialization
{
    [XmlRootAttribute("svg")]
    public class SvgType
    {
        public VariableSetsType variableSets { get; set; }

        public SvgType() { }

        public SvgType(int fileRefQty, int textContentQty)
        {
            variableSets = new VariableSetsType(fileRefQty, textContentQty);
        }
    }
}
