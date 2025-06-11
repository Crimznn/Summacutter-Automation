using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Rutland.PrintFileMaker.Serialization
{
    public class SnSampleDataSetType : SampleDataSetType
    {
        public override void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("dataSetName", base.dataSetName);

            foreach (DictionaryEntry variable in base.Variables)
            {
                               
                string varKey = (string)variable.Key;
                string varValue = (string)variable.Value;

                string xml = string.Format("<{0}><p>{1}</p></{2}>", varKey, varValue, varKey);
                writer.WriteRaw(xml);
            }
        } 
    }
}
