using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
using Rutland.PrintFileMaker.Configuration;

namespace Rutland.PrintFileMaker
{
    
    public enum LayoutType
    {
        ThirdSheet = 0,
        FiveByFive = 1
    }
    
    public partial class Form1 : Form
    {

        public ThirdSheet ThirdSheet { get; set; }
        public FiveByFive FiveByFive { get; set; }
        public string DefaultFolder { get; set; }
        public string DefaultImageFile { get; set; }
        public List<FilePicker> ImageFiles { get; set; }
        public int IndTopIndex { get; set; }
        public int IndBottomIndex { get; set; }

        public Point PnlBottomStartPoint;
        public Point PnlTopStartPoint;

        private ButtonAdd BtnAddToTop;
        private ButtonAdd BtnAddToBottom;

        public LayoutType LayoutType { get; set; }

        public Panel CurrentTopPanel;
        public Panel CurrentBottomPanel;

        public PfmSettings Settings { get; set; }
        
        public Form1()
        {
            InitializeComponent();
            tabLayoutType.SelectedIndexChanged += new EventHandler(tabLayoutType_SelectedIndexChanged);
            this.CurrentTopPanel = this.pnlTop;
            this.CurrentBottomPanel = this.pnlBottom;

            //load settings
            try
            {
                this.Settings = ConfigurationManager.GetSection("pfmSettings") as PfmSettings;
                this.DefaultImageFile = Settings.DefaultBlankImageFile;
                FileInfo fi = new FileInfo(this.DefaultImageFile);
                this.lblDefaultImg.Text = fi.Name;

                if (string.IsNullOrEmpty(Settings.DefaultImageFolder) ||
                    string.IsNullOrEmpty(Settings.DefaultPrintFileFolder) ||
                    string.IsNullOrEmpty(Settings.DefaultBlankImageFile))
                {
                    throw new Exception();
                }
           
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose your application settings by clicking Edit --> Preferences from the menu bar.");
            }
            
            ClearAll();
        }

        private void ClearAll()
        {
            ThirdSheet = new ThirdSheet();
            FiveByFive = new FiveByFive();
            PnlBottomStartPoint = new Point(4, 4);
            PnlTopStartPoint = new Point(4, 4);
            IndTopIndex = 1;
            IndBottomIndex = 25;
            this.pnlBottom.Controls.Clear();
            this.pnlTop.Controls.Clear();
            this.pnl5x5Top.Controls.Clear();
            this.pnl5x5Bottom.Controls.Clear();
            
            this.ImageFiles = new List<FilePicker>();

            lbl5x5Layout.Text = string.Empty;
            lblLayoutText.Text = string.Empty;
        }

        private void addFilePickerToTop(Panel panel, Range t1)
        {
            addFilePickerToTop(panel, t1, t1);
        }

        private void addFilePickerToTop(Panel panel, Range t1, Range t2)
        {
            
            FilePicker newImgFile = new FilePicker(PnlTopStartPoint);

            newImgFile.DefaultFolder = Settings.DefaultImageFolder;
            newImgFile.T1Start = t1.Start;
            newImgFile.T1End = t1.End;
            newImgFile.T2Start = t2.Start;
            newImgFile.T2End = t2.End;
               
            panel.Controls.Add(newImgFile.MyButton);
            panel.Controls.Add(newImgFile.MyFile);

            ImageFiles.Add(newImgFile);
            this.PnlTopStartPoint.Y += 26;
            
        }

        private void addFilePickerToBottom(Panel panel, Range t1)
        {
            addFilePickerToBottom(panel, t1, t1);
        }

        private void addFilePickerToBottom(Panel panel, Range t1, Range t2)
        {
            FilePicker newImgFile = new FilePicker(PnlBottomStartPoint);

            newImgFile.DefaultFolder = Settings.DefaultImageFolder;
            newImgFile.T1Start = t1.Start;
            newImgFile.T1End = t1.End;
            newImgFile.T2Start = t2.Start;
            newImgFile.T2End = t2.End;

            panel.Controls.Add(newImgFile.MyButton);
            panel.Controls.Add(newImgFile.MyFile);

            ImageFiles.Add(newImgFile);
            this.PnlBottomStartPoint.Y += 26;
        }

        private void showIndividual(Panel top, Panel bottom)
        {
            lbl5x5Top.Text = "Images 1 - 13";
            lbl5x5Bottom.Text = "Images 14 - 25";
            
            BtnAddToTop = new ButtonAdd(this.LayoutType);
            BtnAddToTop.Click += new EventHandler(this.BtnAddToTop_Click);
            BtnAddToTop.Size = new Size(23, 23);
            BtnAddToTop.Location = PnlTopStartPoint;
            BtnAddToTop.Text = "+";

            top.Controls.Add(BtnAddToTop);
            
            BtnAddToBottom = new ButtonAdd(this.LayoutType);
            BtnAddToBottom.Click += new EventHandler(this.BtnAddToBottom_Click);
            BtnAddToBottom.Size = new Size(23, 23);
            BtnAddToBottom.Location = PnlBottomStartPoint;
            BtnAddToBottom.Text = "+";

            bottom.Controls.Add(BtnAddToBottom);
        }

        private void showTopBottom(Panel top, Panel bottom)
        {
            PnlBottomStartPoint = new Point(4, 4);
            PnlTopStartPoint = new Point(4, 4);
            // populate first 96 image slots
            this.addFilePickerToTop(top, new Range(1, 24), new Range(49, 72));
            this.addFilePickerToBottom(bottom, new Range(25, 48), new Range(73, 96));

            // extend ranges for layouts that support up to 192 images
            if (this.LayoutType == LayoutType.ThirdSheet)
            {
                this.addFilePickerToTop(top, new Range(97, 120), new Range(145, 168));
                this.addFilePickerToBottom(bottom, new Range(121, 144), new Range(169, 192));
            }
        }

        private void showUniform(Panel top)
        {
            PnlBottomStartPoint = new Point(4, 4);
            PnlTopStartPoint = new Point(4, 4);

            lbl5x5Top.Text = "Images 1 - 25";
            lbl5x5Bottom.Text = string.Empty;

            switch (LayoutType)
            {
                case LayoutType.ThirdSheet:
                    // first 96 image slots
                    this.addFilePickerToTop(top, new Range(1, 48), new Range(49, 96));
                    // extend selection to fill remaining variables through 192
                    this.addFilePickerToTop(top, new Range(97, 144), new Range(145, 192));
                    break;

                case LayoutType.FiveByFive:
                    this.addFilePickerToTop(top, new Range(1, 25), new Range(1, 25));
                    break;

                default:
                    break;
            }
                        
        }

        private void show5x5ByRow(Panel top)
        {
            PnlTopStartPoint = new Point(4, 4);

            lbl5x5Top.Text = "Rows 1 - 5";

            for (int i = 1; i <= 21; i += 5)
            {
                addFilePickerToTop(top, new Range(i, i + 4));
            }
        }
               

        private void BtnAddToTop_Click(object sender, EventArgs e)
        {
            Range r = new Range(this.IndTopIndex, this.IndTopIndex);

            this.addFilePickerToTop(CurrentTopPanel, r, r);
            this.BtnAddToTop.Location = new Point(BtnAddToTop.Location.X, BtnAddToTop.Location.Y +26);
            this.IndTopIndex += 1;

            if ((BtnAddToTop.LayoutType == LayoutType.FiveByFive && this.IndTopIndex > 13) ||
                (this.IndTopIndex > 17))
            {
                BtnAddToTop.Enabled = false;
                BtnAddToTop.Visible = false;
            }
                        
            if (this.IndTopIndex > 24)
            {
                this.IndTopIndex = 49;
            }
        }

        private void BtnAddToBottom_Click(object sender, EventArgs e)
        {
            Range r = new Range(this.IndBottomIndex, this.IndBottomIndex);
            this.addFilePickerToBottom(CurrentBottomPanel, r, r);
            BtnAddToBottom.Location = new Point(BtnAddToBottom.Location.X, BtnAddToBottom.Location.Y + 26);
            this.IndBottomIndex += 1;

            if ((BtnAddToTop.LayoutType == LayoutType.FiveByFive && this.IndBottomIndex > 25) ||
                (this.IndBottomIndex > 41))
            {
                BtnAddToBottom.Enabled = false;
                BtnAddToBottom.Visible = false;
            }
            
            if (this.IndBottomIndex > 48)
            {
                this.IndBottomIndex = 73;
            }
        }

       

        private bool useSerialNumbers()
        {
            if (this.txtSerialNumberList.Lines.Count() > 0)
            {
                return true;
            }
            
            string snStart = snStart = txtSnStart.Text.Trim();
            string snStop = snStop = txtSnStop.Text.Trim();

            if (string.IsNullOrEmpty(snStart) && string.IsNullOrEmpty(snStop))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void validateImages()
        {
            switch (this.LayoutType)
            {
                case LayoutType.ThirdSheet:
                    if (string.IsNullOrEmpty(CbLayoutStyle.SelectedItem as string))
                    {
                        throw new Exception("To generate a print file, a layout style must be selected");
                    }
                    if ((CbLayoutStyle.SelectedItem as string).Equals("Individual") &&
                        string.IsNullOrEmpty(this.DefaultImageFile))
                    {
                        throw new Exception("A default image file must be selected for Individual layout style");
                    }

                    break;

                case LayoutType.FiveByFive: 
                    if (string.IsNullOrEmpty(this.cmbSelect5x5Layout.SelectedItem as string))
                    {
                        throw new Exception("To generate a print file, a layout style must be selected");
                    }
                    if ((cmbSelect5x5Layout.SelectedItem as string).Equals("Individual") &&
                        string.IsNullOrEmpty(this.DefaultImageFile))
                    {
                        throw new Exception("A default image file must be selected for Individual layout style");
                    }
                    break;

                default:
                    break;
            }

            
            
            if (this.ImageFiles.Count == 0)
            {
                throw new Exception("To generate a print file, both layout style and image file(s) must be selected");
            }

            foreach (var img in ImageFiles)
            {
                if (string.IsNullOrEmpty(img.SelectedFile))
                {
                    throw new Exception("Please make sure all image files are selected");
                }
            }
        }
        
        private void btnMakePrintFile_Click(object sender, EventArgs e)
        {
            try
            {
                validateImages();
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.DefaultExt = "xml";
                    sfd.Filter = "Xml Files|*.xml";
                    sfd.InitialDirectory = Settings.DefaultPrintFileFolder;

                    ILayout layout;
                                        

                    if (this.useSerialNumbers())
                    {
                        layout = LayoutFactory.GetLayout(LayoutType, true);
                    }
                    else
                    {
                        layout = LayoutFactory.GetLayout(LayoutType);
                    }

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        if (this.ImageFiles.Count > 0)
                        {
                            ImageFileManager imgFileMgr = new ImageFileManager(Settings);

                            //copy image files to local dir
                            imgFileMgr.CopyToLocal(ImageFiles);
                                                        

                            if (!string.IsNullOrEmpty(this.DefaultImageFile))
                            {
                                imgFileMgr.CopyToLocal(this.DefaultImageFile); 
                                
                                //get the new local defualt image file path
                                layout.DefaultImage = imgFileMgr.GetLocalDefaultImage(this.DefaultImageFile);

                            }

                           
                            layout.PrintFile = sfd.FileName;
                            layout.Initialize();               
                            

                            foreach (FilePicker imgFile in this.ImageFiles)
                            {
                                string selectedFile = string.Empty;

                                if (string.IsNullOrEmpty(imgFile.MyFile.Text))
                                {
                                    if (string.IsNullOrEmpty(this.DefaultImageFile))
                                    {
                                        throw new Exception("Must select image file(s)");
                                    }
                                    
                                    FileInfo dif = new FileInfo(this.DefaultImageFile);
                                    selectedFile = Path.Combine(Settings.LocalImageFolder, dif.Name);
                                }
                                else
                                {
                                    selectedFile = Path.Combine(Settings.LocalImageFolder, imgFile.MyFile.Text);
                                }

                                layout.AddImageToRange(imgFile.T1Start, imgFile.T1End, selectedFile);
                                layout.AddImageToRange(imgFile.T2Start, imgFile.T2End, selectedFile);
                            }

                            //add serial numbers if necessary
                            if (this.useSerialNumbers())
                            {
                                if (string.IsNullOrEmpty(this.DefaultImageFile.Trim())) 
                                {
                                    throw new Exception("Default blank image file must be selected to create serial numbers.");
                                }
                                if (this.txtSerialNumberList.Lines.Count() > 0)
                                {
                                    layout.AddSerialNumbers(this.txtSerialNumberList.Lines);
                                }
                                else
                                {
                                    layout.AddSerialNumbers(txtSnStart.Text, txtSnStop.Text);
                                }
                            }
                           

                            layout.GeneratePrintFile();

                            string msg = string.Format("Printfile \"{0}\" has been created.", sfd.FileName);
                            MessageBox.Show(msg);

                            //clear serial number selections
                            this.txtSnStart.Text = string.Empty;
                            this.txtSnStop.Text = string.Empty;
                            this.txtSerialNumberList.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CbLayoutStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ClearAll();
            this.lblLayoutText.Text = CbLayoutStyle.Text + " Layout";

            this.ImageFiles = new List<FilePicker>();

            if (CbLayoutStyle.Text == "Uniform")
            {
                this.showUniform(pnlTop);
            }

            if (CbLayoutStyle.Text == "Top/Bottom")
            {
                this.showTopBottom(pnlTop, pnlBottom);
            }

            if (CbLayoutStyle.Text == "Individual")
            {
                this.IndBottomIndex = 25;
                this.showIndividual(pnlTop, pnlBottom);
            }
        }

        private void cmbSelect5x5Layout_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ClearAll();
            this.lbl5x5Layout.Text = this.cmbSelect5x5Layout.Text + " Layout";

            this.ImageFiles = new List<FilePicker>();

            if (cmbSelect5x5Layout.Text == "Uniform")
            {
                this.showUniform(pnl5x5Top);
            }

            if (cmbSelect5x5Layout.Text == "By Row")
            {
                this.show5x5ByRow(pnl5x5Top);
            }

            if (cmbSelect5x5Layout.Text == "Individual")
            {
                this.IndBottomIndex = 14;
                this.showIndividual(pnl5x5Top, pnl5x5Bottom);
            }
        }

        private void tabLayoutType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbSelect5x5Layout.SelectedIndex = -1;
            this.CbLayoutStyle.SelectedIndex = -1;
            this.LayoutType = (LayoutType)Enum.ToObject(typeof(LayoutType), tabLayoutType.SelectedIndex);

            switch (LayoutType)
            {
                case LayoutType.ThirdSheet:
                    CurrentTopPanel = pnlTop;
                    CurrentBottomPanel = pnlBottom;
                    break;
                case LayoutType.FiveByFive:
                    CurrentTopPanel = pnl5x5Top;
                    CurrentBottomPanel = pnl5x5Bottom;
                    lbl5x5Top.Text = string.Empty;
                    lbl5x5Bottom.Text = string.Empty;
                    break;
                default:
                    break;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savePrintFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnMakePrintFile_Click(sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAbout frmAbout = new FrmAbout();
                frmAbout.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSettings settings = new FrmSettings();
            settings.Show();
        }

        private void btnImportSns_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        this.txtSerialNumberList.Text = readTextFromFile(ofd.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private string readTextFromFile(string fileName)
        {
            FileInfo fileInfo = new FileInfo(fileName);

            if (fileInfo.Extension.StartsWith(".txt"))
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string s = sr.ReadToEnd();
                    s = s.Replace("\t", "\r\n");

                    return s;
                }             
            }
                        

            throw new Exception("Unsupported File Type");
        }

        private string readExcel(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
