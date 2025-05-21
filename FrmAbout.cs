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
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();

            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("Printfile Maker");
            sb.AppendLine("Version 2.0");
            sb.AppendLine("\u00a92011 Rutland Corporation");
            sb.AppendLine("All rights reserved");

            this.lblText.Text = sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
