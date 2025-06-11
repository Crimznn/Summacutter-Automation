using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Rutland.PrintFileMaker.Serialization
{
    public static class XmpFormatter
    {

        public static string FormatXmp(string xml)
        {
            string header = "\n<!DOCTYPE svg PUBLIC \"-//W3C//DTD SVG 20001102//EN\"    " +
                                "\"http://www.w3.org/TR/2000/CR-SVG-20001102/DTD/svg-20001102.dtd\" [\n" +
                                "\t<!ENTITY ns_graphs \"http://ns.adobe.com/Graphs/1.0/\">\n" +
                                "\t<!ENTITY ns_vars \"http://ns.adobe.com/Variables/1.0/\">\n" +
                                "\t<!ENTITY ns_imrep \"http://ns.adobe.com/ImageReplacement/1.0/\">\n" +
                                "\t<!ENTITY ns_custom \"http://ns.adobe.com/GenericCustomNamespace/1.0/\">\n" +
                                "\t<!ENTITY ns_flows \"http://ns.adobe.com/Flows/1.0/\">\n" +
                                "<!ENTITY ns_extend \"http://ns.adobe.com/Extensibility/1.0/\">\n" +
                                "]>\n";

            //open header file
            //using (StreamReader streamReader = new StreamReader("Resources\\XmpHeader.txt"))
            //{
            //     header = streamReader.ReadToEnd();
            //}

            //add namespace prefix to sampleDataSet elements
            xml = xml.Replace("sampleDataSet", "v:sampleDataSet");

            //get rid of serializer derived class type definitions
            xml = xml.Replace("d5p1:type=\"FileRefVariableType\" ", string.Empty);
            xml = xml.Replace("d5p1:type=\"TextContentVariableType\" ", string.Empty);
            xml = xml.Replace("xmlns:d5p1=\"http://www.w3.org/2001/XMLSchema-instance\" ", string.Empty);

            //get rid of /default tag
            xml = xml.Replace("<default/>", "");
            xml = xml.Replace("<default />", "");

            //add weird header
            xml = xml.Replace("<svg>",
                string.Format("{0}<svg>", header));



            return xml;

        }
    }
}
