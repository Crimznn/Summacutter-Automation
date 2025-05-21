using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using Rutland.PrintFileMaker.Serialization;

namespace Rutland.PrintFileMaker
{
    public class ThirdSheet : Layout, ILayout
    {
        private int ImageQty;

        public ThirdSheet() : this(false, false)
        {
        }

        public ThirdSheet(bool hasTextContent)
            : this(hasTextContent, false)
        {
        }

        public ThirdSheet(bool hasTextContent, bool doubleImages)
            : base(doubleImages ? 192 : 96, hasTextContent ? 48 : 0)
        {
            this.ImageQty = doubleImages ? 192 : 96;
        }


        public override void Initialize()
        {
            _Images = new OrderedDictionary();

            for (int i = 1; i <= ImageQty; i++)
            {
                string newKey = string.Format(VARIABLE_KEY, i);
                _Images.Add(newKey, base.DefaultImage);
            }

        }

    }
}
