using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using Rutland.PrintFileMaker;
using Rutland.PrintFileMaker.Serialization;
using System.IO;
using System.Configuration;
using Rutland.PrintFileMaker.Configuration;

namespace Rutland.PrintFileMaker.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.TestXml();
            //p.TestReadFile();
            //p.TestDic();
            //p.TestLayout();
            p.Test5x5();
            //p.TestConfig();
            //p.testIntConversion();
            //p.TestTs();

            Console.ReadKey();
        }

        //public void TestReadFile()
        //{
        //    XmpFormatter xf = new XmpFormatter();

        //    Console.ReadKey();
        //}

        void testIntConversion()
        {
            Console.WriteLine(Int64.MaxValue);

            string startingSn = "00001";

            //get digits
            int digits = startingSn.ToCharArray().Count();

            Console.WriteLine(digits);

            Int64 myInt = Convert.ToInt64(startingSn);

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(myInt++.ToString(string.Format("D{0}", digits)));
                //myInt++;
                //convert back to string


            }
        }

        public void TestConfig()
        {
            System.Configuration.Configuration c = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            MikeConfig config = c.GetSection("mikesSettings") as MikeConfig;
            Console.WriteLine("quote={0}, yourage={1}", config.QuoteOfTheDay, config.YourAge);

        }

        public void TestLayout()
        {
            ThirdSheet ts = new ThirdSheet();
            ts.PrintFile = "c:\\aaa\\xml\\mikeXml.xml";
            ts.DefaultImage = "c:\\aaa\\defaultImage.asi";

            ts.AddImageToRange(1, 24, "c:\\Mike\\myImageTop.asi");
            ts.AddImageToRange(25, 48, "c:\\Mike\\myImageBottom.img");
            ts.GeneratePrintFile();
        }

        public void Test5x5()
        {
            FiveByFive f = new FiveByFive(true);
            f.PrintFile = @"c:\aaa\xml\mpf.xml";
            f.DefaultImage = @"c:\aaa\variables.xml";
            f.AddImageToRange(1, 25, @"c:\aaa\mikeXml.xml");

            List<string> serialNums = new List<string>();
            for (int i = 0; i < 32; i++)
            {
                serialNums.Add(i.ToString("D4"));
            }

            f.AddSerialNumbers(serialNums.ToArray());

            //f.AddSerialNumbers(51, "0001");

            try
            {
                f.GeneratePrintFile();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        void TestTs()
        {
            ThirdSheet ts = new ThirdSheet(true);
            ts.PrintFile = @"c:\aaa\xml\mpf.xml";
            ts.DefaultImage = @"c:\aaa\variables.xml";
            ts.AddImageToRange(1, 192, @"c:\aaa\mikeXml.xml");

            ts.AddSerialNumbers(480, "00001");

            try
            {
                ts.GeneratePrintFile();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());                
            }

            
        }

        public void TestDic()
        {
            OrderedDictionary od = new OrderedDictionary();
            od.Add("default", "novalue");

            for (int i = 1; i <= 10; i++)
            {
                string key = "v" + i;
                od.Add(key, string.Empty);
            }

            od["v1"] = "Mike";



            foreach (DictionaryEntry entry in od)
            {
                if (entry.Key.Equals("default")) continue;
                Console.WriteLine("key:\t{0}\nvalue:\t{1}", entry.Key, entry.Value);
            }


        }

        //public void TestXml()
        //{

        //    //build objects for sample xml

        //    SvgType svg = new SvgType();
        //    VariableSetsType varSets = new VariableSetsType();
        //    VariableSetType varSet = new VariableSetType();
        //    VariablesType vt = new VariablesType();
        //    vt.variable = new List<VariableType>();

        //    for (int i = 1; i <= 96; i++)
        //    {

        //        VariableType myVt = new VariableType();
        //        myVt.varName = "Variable" + i;
        //        myVt.trait = "fileref";
        //        myVt.category = "http://ns.adobe.com/Variables/1.0/";

        //        vt.variable.Add(myVt);
        //    }

        //    varSet.variables = vt;
        //    varSets.variableSet = varSet;
        //    svg.variableSets = varSets;


        //    SampleDataSetsType sDataSets = new SampleDataSetsType();
        //    //add namespaces




        //    SampleDataSetType sDataSet = new SampleDataSetType(96);


        //    List<SampleDataSetType> dsList = new List<SampleDataSetType>();
        //    for (int i = 1; i <= 4; i++)
        //    {
        //        string dsName = string.Format("Data Set {0}", i);
        //        sDataSet = newDataSet();
        //        sDataSet.dataSetName = dsName;
        //        dsList.Add(sDataSet);
        //    }

        //    sDataSets.sampleDataSet = dsList;
        //    varSet.sampleDataSets = sDataSets;

        //    //serialize
        //    XmlStringSerializer xs = new XmlStringSerializer();
        //    //xs.OmitNamespaces = false;

        //    string xml = xs.ToXml(svg, typeof(SvgType));
        //    string xmp = XmpFormatter.FormatXmp(xml);
        //    string filePath = "c:\\aaa\\xml\\Jaytest1.xml";

        //    using (StreamWriter sw = new StreamWriter(filePath))
        //    {
        //        sw.Write(xmp);
        //    }

        //Console.WriteLine(xs.ToObject(typeof(SvgType), "c:\\aaa\\xml\\test3.xml"));

        //SvgType newSvg = (SvgType)xs.ToObject(typeof(SvgType), "c:\\aaa\\xml\\test3.xml");

        //Console.WriteLine(xs.ToXml(newSvg, typeof(SvgType)));



        //    Console.ReadKey();


        //}

        //private SampleDataSetType newDataSet()
        //{
        //    SampleDataSetType sDataSet = new SampleDataSetType(96);

        //    string fileUri = "file://///Server1/compdata1/Icon Production/Jay's Folder/Placed art file testing/Placed Art Test 1.ai";

        //    string keyName = string.Empty;

        //    for (int i = 1; i <= 96; i++)
        //    {
        //        keyName = string.Format("Variable{0}", i);
        //        sDataSet.Variables[keyName] = fileUri;
        //    }


        //    return sDataSet;
        //}
    }
}
