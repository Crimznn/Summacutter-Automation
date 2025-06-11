using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Rutland.PrintFileMaker.Serialization
{
    public class SampleDataSetsType
    {

        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces xmlns { get; set; }

        [XmlElement]
        public List<SampleDataSetType> sampleDataSet { get; set; }

        public SampleDataSetsType()
        {
            xmlns = new XmlSerializerNamespaces();
            this.xmlns.Add("", "http://ns.adobe.com/GenericCustomNamespace/1.0/");
            this.xmlns.Add("v", "http://ns.adobe.com/Variables/1.0/");

            sampleDataSet = new List<SampleDataSetType>();
        }
    }
}
