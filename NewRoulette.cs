using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using Rutland.PrintFileMaker.Serialization;

namespace Rutland.PrintFileMaker
{
    public class NewRoulette : Layout, ILayout
    {
        private int ImageQty;

        public NewRoulette() : base(192)
        {
            this.ImageQty = 192;
        }

        public NewRoulette(bool hasTextContent)
            : base(192, 96)
        {
            this.ImageQty = 192;
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
