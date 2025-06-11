using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rutland.PrintFileMaker
{
    public class Range
    {
        private int start;
        private int end;

        public Range(int s, int e)
        {
            this.start = s;
            this.end = e;
        }

        public int Start
        {
            get
            {
                return this.start;
            }
        }

        public int End
        {
            get
            {
                return this.end;
            }
        }
    }
}
