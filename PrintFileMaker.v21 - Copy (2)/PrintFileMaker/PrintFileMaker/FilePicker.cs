using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Rutland.PrintFileMaker.Serialization;

namespace Rutland.PrintFileMaker
{
    public class FilePicker
    {
        public Button MyButton { get; set; }
        public TextBox MyFile { get; set; }
        public string DefaultFolder { get; set; }
        public int T1Start { get; set; }
        public int T1End { get; set; }
        public int T2Start { get; set; }
        public int T2End { get; set; }

        private string _SelectedFile;

        public FilePicker(Point start)
        {
            this.BuildButton(start);
            this.buildTextBox(start.Y);
            this.MyButton.Click += new EventHandler(this.MyButton_Click);            
        }

        private void BuildButton(Point start)
        {
            this.MyButton = new Button();
            this.MyButton.Text = "File";
            this.MyButton.Size = new Size(33, 23);
            this.MyButton.Location = start;

        }

        private void buildTextBox(int y)
        {
            this.MyFile = new TextBox();
            this.MyFile.Size = new Size(275, 20);
            this.MyFile.Location = new Point(43, y);
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                Form1 frm1 = Application.OpenForms["Form1"] as Form1;
                ofd.InitialDirectory = frm1.Settings.DefaultImageFolder;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.MyFile.Text = ofd.SafeFileName;
                    this._SelectedFile = ofd.FileName;
                }
            }
        }

        public string SelectedFile
        {
            get
            {
                return _SelectedFile;
            }
        }
        

    }
}
