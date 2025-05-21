using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using Rutland.PrintFileMaker.Configuration;

namespace Rutland.PrintFileMaker
{
    public partial class FrmSettings : Form
    {
        private PfmSettings settings;
        private System.Configuration.Configuration config;

        public FrmSettings()
        {
            InitializeComponent();

            try
            {
                config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                settings = config.GetSection("pfmSettings") as PfmSettings;
                txtDefaultPrintFileFolder.Text = settings.DefaultPrintFileFolder;
                txtDefaultImageFileFolder.Text = settings.DefaultImageFolder;
                txtLocalImageFolder.Text = settings.LocalImageFolder;
                txtDefaultBlankImage.Text = settings.DefaultBlankImageFile;
            }
            catch (Exception)
            {
                throw new Exception("Error opening application settings. The configuration file may be corrupt.\n" +
                                "Please replace with original config file and try again.");                                
            }

            lblPrintFileFolder.MouseHover += new EventHandler(lblPrintFileFolder_MouseHover);
            lblImgFileFolder.MouseHover += new EventHandler(lblImgFileFolder_MouseHover);
            lblTempImgFolder.MouseHover += new EventHandler(lblTempImgFolder_MouseHover);
            lblDefaultBlankImageFile.MouseHover += new EventHandler(lblDefaultBlankImageFile_MouseHover);
            
        }

        private void btnSelectPfFolder_Click(object sender, EventArgs e)
        {
            selectFolder(sender, e, txtDefaultPrintFileFolder);
        }

        private void btnSelectIfFolder_Click(object sender, EventArgs e)
        {
            selectFolder(sender, e, this.txtDefaultImageFileFolder);
        }

        private void btnLocalImageFolder_Click(object sender, EventArgs e)
        {
            selectFolder(sender, e, this.txtLocalImageFolder);
        }

        private void btnDefaultBlankImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtDefaultBlankImage.Text = ofd.FileName;
                }
            }
        }
                      

        private void selectFolder(object sender, EventArgs e, TextBox tb)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    tb.Text = fbd.SelectedPath;
                }
            }
        }
        
        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                settings.DefaultPrintFileFolder = txtDefaultPrintFileFolder.Text;
                settings.DefaultImageFolder = txtDefaultImageFileFolder.Text;
                settings.LocalImageFolder = txtLocalImageFolder.Text;
                settings.DefaultBlankImageFile = txtDefaultBlankImage.Text;

                settings.SectionInformation.ForceSave = true;

                config.Save(ConfigurationSaveMode.Modified);

                Form1 mainForm = Application.OpenForms["Form1"] as Form1;
                mainForm.Settings = settings;

                if (!string.IsNullOrEmpty(txtDefaultBlankImage.Text.Trim()))
                {
                    FileInfo fi = new FileInfo(this.txtDefaultBlankImage.Text);

                    mainForm.lblDefaultImg.Text = fi.Name;
                    mainForm.DefaultImageFile = this.txtDefaultBlankImage.Text;
                }

                ConfigurationManager.RefreshSection("pfmSettings");
            }
            catch (Exception)
            {
                MessageBox.Show("Error saving settings. The configuration file may be corrupt.\n" +
                                "Please replace with original config file and try again.");
            }
            
            this.Close();

            
        }

        private void showTip(string tipText, object sender)
        {
            ToolTip toolTip = new ToolTip();

            toolTip.AutoPopDelay = 10000;
            toolTip.InitialDelay = 200;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            toolTip.IsBalloon = true;
            

            toolTip.SetToolTip(sender as Control, tipText);
        }

        private void lblPrintFileFolder_MouseHover(object sender, EventArgs e)
        {
            string tipText = "Local directory where print files will be stored.";
            showTip(tipText, sender);
        }

        private void lblImgFileFolder_MouseHover(object sender, EventArgs e)
        {
            string tipText = "Local or network directory from which you will select \nthe art or image files.";
            showTip(tipText, sender);
        }


        private void lblTempImgFolder_MouseHover(object sender, EventArgs e)
        {
            string tipText = "Local directory to store temporary image files. If you \n" +
                             "do not choose a local directory, the application will \n" +
                             "create a directory called \"Images\" inside the application\n" +
                             "directory";
            showTip(tipText, sender);
        }


        private void lblDefaultBlankImageFile_MouseHover(object sender, EventArgs e)
        {
            string tipText = "Blank image file to use for individual layouts or \n" +
                             "incomplete printfiles.";

            showTip(tipText, sender);
        }

       

    }
}
