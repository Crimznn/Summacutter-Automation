using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;

namespace Rutland.PrintFileMaker
{
    public class FiveByFive : Layout, ILayout
    {
        private int ImageQty;

        public FiveByFive() : base(25)
        {
            this.ImageQty = 25;
        }

        public FiveByFive(bool hasTextContent) 
            : base(25, 25)
        {
            this.ImageQty = 25;
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
