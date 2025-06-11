using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rutland.PrintFileMaker
{
    public class LayoutFactory
    {
        public static ILayout GetLayout(LayoutType lType) 
        {
            switch (lType)
            {
                case LayoutType.ThirdSheet:
                    return new ThirdSheet();

                case LayoutType.FiveByFive:
                    return new FiveByFive();

                default:
                    throw new Exception("Invalid Layout Type");
            }
        }

        public static ILayout GetLayout(LayoutType lType, bool hasSerialNumbers)
        {
            switch (lType)
            {
                case LayoutType.ThirdSheet:
                    return new ThirdSheet(hasSerialNumbers);

                case LayoutType.FiveByFive:
                    return new FiveByFive(hasSerialNumbers);

                default:
                    throw new Exception("Invalid Layout Type");
            }
        }
    }
}
