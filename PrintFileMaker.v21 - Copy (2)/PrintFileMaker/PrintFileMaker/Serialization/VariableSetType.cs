using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Rutland.PrintFileMaker.Serialization
{
    public class VariableSetType
    {

        [XmlAttribute]
        public string locked { get; set; }

        [XmlAttribute]
        public string varSetName { get; set; }

        public VariablesType variables { get; set; }
        public SampleDataSetsType sampleDataSets { get; set; }

        public VariableSetType() { }

        public VariableSetType(int fileRefQty, int textContentQty)
        {
            this.locked = "none";
            this.varSetName = "binding1";

            variables = new VariablesType(fileRefQty, textContentQty);
            sampleDataSets = new SampleDataSetsType();
        }
    }
}
