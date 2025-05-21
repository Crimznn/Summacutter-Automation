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

                case LayoutType.NewRoulette:
                    return new NewRoulette();

                default:
                    throw new Exception("Invalid Layout Type");
            }
        }

        public static ILayout GetLayout(LayoutType lType, bool hasSerialNumbers)
        {
            switch (lType)
            {
                case LayoutType.ThirdSheet:
                    return new ThirdSheet(true);

                case LayoutType.FiveByFive:
                    return new FiveByFive(true);

                case LayoutType.NewRoulette:
                    return new NewRoulette(true);

                default:
                    throw new Exception("Invalid Layout Type");
            }
        }
    }
}
