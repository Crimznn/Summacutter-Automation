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
    [XmlInclude(typeof(SnSampleDataSetType))]
    public class SampleDataSetType : IXmlSerializable
    {

        public string dataSetName { get; set; }

        public OrderedDictionary Variables { get; set; }

        public SampleDataSetType() { }

        //public SampleDataSetType(int numberOfVariables)
        //{
        //    //Variables = new OrderedDictionary();
        //    //this.dataSetName = "Data Set 1";

        //    //for (int i = 1; i <= numberOfVariables; i++)
        //    //{
        //    //    string newKey = "Variable" + i;
        //    //    Variables.Add(newKey, string.Empty);
        //    //}
        //}



        #region IXmlSerializable Members

        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        public virtual void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("dataSetName", this.dataSetName);

            foreach (DictionaryEntry variable in Variables)
            {
                string value = variable.Value as string;
                string key = variable.Key as string;

                if (value.StartsWith("file:", true, null))
                {
                    writer.WriteElementString(key, value);
                }
                else
                {                   
                    if(string.IsNullOrEmpty(value.Trim())) 
                    {
                        value = "&#160;";
                    }
                    string xml = string.Format("<{0}><p>{1}</p></{2}>", key, value, key);
                    writer.WriteRaw(xml);
                }
            }
        }

        #endregion
    }
}
