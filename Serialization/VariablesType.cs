using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Rutland.PrintFileMaker.Serialization
{

    [XmlInclude(typeof(FileRefVariableType))]
    [XmlInclude(typeof(TextContentVariableType))]
    public class VariablesType
    {
        [XmlElement]
        public List<VariableType> variable { get; set; }

        public VariablesType() { }

        public VariablesType(int fileRefQty, int textContentQty)
        {
            variable = new List<VariableType>();
            VariableType vt;

            //create the fileref variables
            int i = 1;
            while ( i <= fileRefQty )
            {
                vt = new FileRefVariableType();
                vt.varName = "Variable" + i++;
                variable.Add(vt);
            }

            //create the textcontentvariables
            while (i <= (fileRefQty + textContentQty))
            {
                vt = new TextContentVariableType();
                vt.varName = "Variable" + i++;
                variable.Add(vt);
            }
        }

    }
}
