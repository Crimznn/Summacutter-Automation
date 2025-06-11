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

        public ThirdSheet() : this(false)
        {
        }

        public ThirdSheet(bool hasTextContent)
            : base(192, hasTextContent ? 192 : 0)
        {
            this.ImageQty = 192;
        }


        public override void Initialize()
        {
            _Images = new OrderedDictionary();
            //_Images.Add("default", string.Empty);

            for (int i = 1; i <= ImageQty; i++)
            {
                string newKey = string.Format(VARIABLE_KEY, i);
                _Images.Add(newKey, base.DefaultImage);

            }

        }

    }
}
