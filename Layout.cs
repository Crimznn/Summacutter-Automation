using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rutland.PrintFileMaker.Serialization;

namespace Rutland.PrintFileMaker
{

    
    public abstract class Layout
    {

        //private members
        protected OrderedDictionary _Images;
        protected List<OrderedDictionary> _SerialNumbers;
        protected string formattedPrintFile;
        protected SvgType printFileXml;
        protected List<SampleDataSetType> SampleDataSets;
        protected string VARIABLE_KEY = "Variable{0}";
        protected int dataSetNumber = 1;
        private string _DefaultImage;
        int FileRefQty;
        int TextContentQty;
        

        public abstract void Initialize();

        public Layout(int fileRefQty, int textContentQty)
        {
            this.FileRefQty = fileRefQty;
            this.TextContentQty = textContentQty;
            DefaultImage = string.Empty;
            PrintFile = string.Empty;
            _Images = new OrderedDictionary();
            _SerialNumbers = new List<OrderedDictionary>();
        }

        public Layout(int fileRefQty)
            : this(fileRefQty, 0)
        {

        }

        


        //public methods
        public bool GeneratePrintFile()
        {
            printFileXml = new SvgType(FileRefQty, TextContentQty);

            if (_SerialNumbers.Count > 0)
            {
                //add a dataset with same filerefs for each set of serial numbers                
                foreach (var serialNumberSet in _SerialNumbers)
                {

                    SampleDataSetType sds = new SampleDataSetType();

                    //get the dataset number
                    int dataSetNumber = printFileXml.variableSets.variableSet.sampleDataSets.sampleDataSet.Count + 1;

                    sds.dataSetName = string.Format("Data Set {0}", dataSetNumber);
                    sds.Variables = new OrderedDictionary();

                    //add images to dataset
                    foreach (DictionaryEntry image in this._Images)
                    {
                        sds.Variables.Add(image.Key, image.Value);
                    }

                    
                    //add serialnumbers to dataset
                    int varNum = 1;

                    foreach (DictionaryEntry serialNum in serialNumberSet)
                    {
                        //if serialnumber is blank, set corresponding images to default blank image
                        if (string.IsNullOrEmpty((serialNum.Value as string).Trim())) 
                        {                            
                            if (this.FileRefQty == 96) //adjust thirdsheet images 
                            {                                
                                //top
                                string key = string.Format("Variable{0}", Convert.ToString(varNum));
                                sds.Variables[key] = this.DefaultImage;
                                //bottom
                                key = string.Format("Variable{0}", Convert.ToString(varNum + 24));
                                sds.Variables[key] = this.DefaultImage;                                                               
                            }
                            else //adjust 5x5 image (-25)
                            {                                
                                string key = string.Format("Variable{0}", Convert.ToString(varNum));
                                sds.Variables[key] = this.DefaultImage;
                            }                           
                        }
                        //varNum to skip bottoms of 1 - 24
                        if (varNum == 24 && this.FileRefQty == 96)
                        {
                            varNum += 24;
                        }

                        sds.Variables.Add(serialNum.Key, serialNum.Value);
                        varNum++;
                    }

                    printFileXml.variableSets.variableSet.sampleDataSets.sampleDataSet.Add(sds);

                }
            }
            else
            {
                //process just filerefs
                SampleDataSetType sds = new SampleDataSetType();

                //get the dataset number
                int dataSetNumber = printFileXml.variableSets.variableSet.sampleDataSets.sampleDataSet.Count + 1;

                sds.dataSetName = string.Format("Data Set {0}", dataSetNumber);
                sds.Variables = _Images;

                printFileXml.variableSets.variableSet.sampleDataSets.sampleDataSet.Add(sds);
            }

           
            XmlStringSerializer xs = new XmlStringSerializer();

            string printFileOutput = XmpFormatter.FormatXmp(xs.ToXml(printFileXml, typeof(SvgType)));

            xs.StringToXmlFile(printFileOutput, PrintFile);

            return true;
        }


        public void AddImage(int Position, string ImageFile)
        {
            Uri fileUri = new Uri(ImageFile);

            this._Images[(Position-1)] = fileUri.AbsoluteUri;
        }

        public void AddImageToRange(int StartLocation, int EndLocation, string ImageFile)
        {
            for (int i = StartLocation; i <= EndLocation; i++)
            {
                this.AddImage(i, ImageFile);
            }
        }

        public void AddSerialNumbers(string[] serialNumbers)
        {
            List<string> listSerialNums = serialNumbers.ToList<string>();

            int totalSerialNumbers = listSerialNums.Count;
            
            //determine number of datasets for serial numbers
            int dataSetQty = totalSerialNumbers / TextContentQty;
            int missingValues = (TextContentQty - (totalSerialNumbers % TextContentQty)) % TextContentQty;
            

            if (missingValues > 0)
            {
                dataSetQty++;

                //fill in missing values with empty strings
                for (int i = 0; i < missingValues; i++)
                {
                    listSerialNums.Add(string.Empty);
                }                
            }

           
            //build datasets            
            int startingIndex = 0;

            for (int i = 0; i < dataSetQty; i++)
            {                
                List<string> snSubSet = listSerialNums.GetRange(startingIndex, TextContentQty);   

                OrderedDictionary dataset = this.buildSnDataSet(snSubSet.ToArray());
                this._SerialNumbers.Add(dataset);

                startingIndex += TextContentQty;
            }
            
        }

        public void AddSerialNumbers(string snStart, string snStop)
        {
            Int64 intStart;
            Int64 intStop;

            try
            {
                intStart = Convert.ToInt64(snStart);
                intStop = Convert.ToInt64(snStop);
            }
            catch (Exception)
            {
                throw new Exception("Invalid serial numbers - must be numeric");
            }

            if (intStart > intStop)
            {
                throw new Exception("The \"Start\" serial number must be less than the \"Stop\" serial number");
            }

            this.AddSerialNumbers((intStop - intStart + 1), snStart);
        }
               
        public void AddSerialNumbers(Int64 qty, String startingValue)
        {
            //determine number of datasets for serial numbers
            Int64 dataSetQty = qty / TextContentQty;

            if (qty % TextContentQty > 0)
            {
                dataSetQty++;
            }

            //get number of digits for leading zeros
            int digits = startingValue.ToCharArray().Count();

            //get integer value of starting value
            Int64 serialNum = Convert.ToInt64(startingValue);
            Int64 endingSerialNum = serialNum + qty;

            //build up ordered dictionary for each dataset
            for (int i = 0; i < dataSetQty; i++)
            {
                //build string[] of formatted serial numbers
                string[] serialNumbers = new string[TextContentQty];

                for (int j = 0; j < TextContentQty; j++)
                {
                    serialNumbers[j] = serialNum++.ToString(string.Format("D{0}", digits));
                    if (serialNum > endingSerialNum)
                    {
                        serialNumbers[j] = string.Empty;
                    }
                }

                //build ordered dictionary for dataset
                OrderedDictionary dataset = this.buildSnDataSet(serialNumbers);

                this._SerialNumbers.Add(dataset);
            }
            
        }

        private OrderedDictionary buildSnDataSet(string[] serialNumbers)
        {
            OrderedDictionary dataSet = new OrderedDictionary();
            
            int i = FileRefQty + 1;

            foreach (var sn in serialNumbers)
            {
                string newKey = string.Format(VARIABLE_KEY, i++);
                dataSet[newKey] = sn;
            }
            
            return dataSet;
        }

        //Public Properties

        public string PrintFile { get; set; }

        public string DefaultImage
        {
            get
            {
                return _DefaultImage;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _DefaultImage = value;
                }
                else
                {
                    try
                    {
                        _DefaultImage = new Uri(value).AbsoluteUri;
                    }
                    catch (Exception)
                    {

                        _DefaultImage = value;
                    }
                }
                Initialize();
            }
        }

    }
}
