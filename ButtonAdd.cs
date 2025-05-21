using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rutland.PrintFileMaker
{
    public class ButtonAdd : Button
    {
        public LayoutType LayoutType { get; set; }

        public ButtonAdd(LayoutType lt) : base()
        {
            this.LayoutType = lt;
        }
    }
}
