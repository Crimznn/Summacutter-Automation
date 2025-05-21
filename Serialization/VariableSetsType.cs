using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Rutland.PrintFileMaker.Serialization
{
    public class VariableSetsType
    {
        public VariableSetType variableSet { get; set; }

        public VariableSetsType() { }

        public VariableSetsType(int fileRefQty, int textContentQty)
        {
            variableSet = new VariableSetType(fileRefQty, textContentQty);
        }
    }
}
