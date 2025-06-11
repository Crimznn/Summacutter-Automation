using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rutland.PrintFileMaker
{
    public interface ILayout
    {
        string PrintFile { get; set; }
        string DefaultImage { get; set; }
        void Initialize();
        void AddImageToRange(int start, int end, string selectedFile);
        void AddSerialNumbers(Int64 qty, String startingValue);
        void AddSerialNumbers(string startingValue, string endingValue);
        void AddSerialNumbers(string[] serialNumbers);
        bool GeneratePrintFile();

    }
}
