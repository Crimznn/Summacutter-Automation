namespace Rutland.PrintFileMaker
{
    partial class FrmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectPfFolder = new System.Windows.Forms.Button();
            this.txtDefaultPrintFileFolder = new System.Windows.Forms.TextBox();
            this.lblPrintFileFolder = new System.Windows.Forms.Label();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.lblImgFileFolder = new System.Windows.Forms.Label();
            this.txtDefaultImageFileFolder = new System.Windows.Forms.TextBox();
            this.btnSelectIfFolder = new System.Windows.Forms.Button();
            this.txtLocalImageFolder = new System.Windows.Forms.TextBox();
            this.btnLocalImageFolder = new System.Windows.Forms.Button();
            this.lblTempImgFolder = new System.Windows.Forms.Label();
            this.txtDefaultBlankImage = new System.Windows.Forms.TextBox();
            this.btnDefaultBlankImage = new System.Windows.Forms.Button();
            this.lblDefaultBlankImageFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelectPfFolder
            // 
            this.btnSelectPfFolder.Location = new System.Drawing.Point(28, 37);
            this.btnSelectPfFolder.Name = "btnSelectPfFolder";
            this.btnSelectPfFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPfFolder.TabIndex = 0;
            this.btnSelectPfFolder.Text = "Select";
            this.btnSelectPfFolder.UseVisualStyleBackColor = true;
            this.btnSelectPfFolder.Click += new System.EventHandler(this.btnSelectPfFolder_Click);
            // 
            // txtDefaultPrintFileFolder
            // 
            this.txtDefaultPrintFileFolder.Location = new System.Drawing.Point(109, 39);
            this.txtDefaultPrintFileFolder.Name = "txtDefaultPrintFileFolder";
            this.txtDefaultPrintFileFolder.Size = new System.Drawing.Size(340, 20);
            this.txtDefaultPrintFileFolder.TabIndex = 1;
            // 
            // lblPrintFileFolder
            // 
            this.lblPrintFileFolder.AutoSize = true;
            this.lblPrintFileFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintFileFolder.Location = new System.Drawing.Point(25, 21);
            this.lblPrintFileFolder.Name = "lblPrintFileFolder";
            this.lblPrintFileFolder.Size = new System.Drawing.Size(141, 13);
            this.lblPrintFileFolder.TabIndex = 2;
            this.lblPrintFileFolder.Text = "Default Print File Folder";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(374, 303);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSettings.TabIndex = 3;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // lblImgFileFolder
            // 
            this.lblImgFileFolder.AutoSize = true;
            this.lblImgFileFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImgFileFolder.Location = new System.Drawing.Point(25, 84);
            this.lblImgFileFolder.Name = "lblImgFileFolder";
            this.lblImgFileFolder.Size = new System.Drawing.Size(149, 13);
            this.lblImgFileFolder.TabIndex = 4;
            this.lblImgFileFolder.Text = "Default Image File Folder";
            // 
            // txtDefaultImageFileFolder
            // 
            this.txtDefaultImageFileFolder.Location = new System.Drawing.Point(109, 102);
            this.txtDefaultImageFileFolder.Name = "txtDefaultImageFileFolder";
            this.txtDefaultImageFileFolder.Size = new System.Drawing.Size(340, 20);
            this.txtDefaultImageFileFolder.TabIndex = 6;
            // 
            // btnSelectIfFolder
            // 
            this.btnSelectIfFolder.Location = new System.Drawing.Point(28, 100);
            this.btnSelectIfFolder.Name = "btnSelectIfFolder";
            this.btnSelectIfFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectIfFolder.TabIndex = 5;
            this.btnSelectIfFolder.Text = "Select";
            this.btnSelectIfFolder.UseVisualStyleBackColor = true;
            this.btnSelectIfFolder.Click += new System.EventHandler(this.btnSelectIfFolder_Click);
            // 
            // txtLocalImageFolder
            // 
            this.txtLocalImageFolder.Location = new System.Drawing.Point(109, 172);
            this.txtLocalImageFolder.Name = "txtLocalImageFolder";
            this.txtLocalImageFolder.Size = new System.Drawing.Size(340, 20);
            this.txtLocalImageFolder.TabIndex = 9;
            // 
            // btnLocalImageFolder
            // 
            this.btnLocalImageFolder.Location = new System.Drawing.Point(28, 170);
            this.btnLocalImageFolder.Name = "btnLocalImageFolder";
            this.btnLocalImageFolder.Size = new System.Drawing.Size(75, 23);
            this.btnLocalImageFolder.TabIndex = 8;
            this.btnLocalImageFolder.Text = "Select";
            this.btnLocalImageFolder.UseVisualStyleBackColor = true;
            this.btnLocalImageFolder.Click += new System.EventHandler(this.btnLocalImageFolder_Click);
            // 
            // lblTempImgFolder
            // 
            this.lblTempImgFolder.AutoSize = true;
            this.lblTempImgFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempImgFolder.Location = new System.Drawing.Point(25, 154);
            this.lblTempImgFolder.Name = "lblTempImgFolder";
            this.lblTempImgFolder.Size = new System.Drawing.Size(235, 13);
            this.lblTempImgFolder.TabIndex = 7;
            this.lblTempImgFolder.Text = "Local Temporary Image Folder (optional)";
            // 
            // txtDefaultBlankImage
            // 
            this.txtDefaultBlankImage.Location = new System.Drawing.Point(109, 248);
            this.txtDefaultBlankImage.Name = "txtDefaultBlankImage";
            this.txtDefaultBlankImage.Size = new System.Drawing.Size(340, 20);
            this.txtDefaultBlankImage.TabIndex = 12;
            // 
            // btnDefaultBlankImage
            // 
            this.btnDefaultBlankImage.Location = new System.Drawing.Point(28, 246);
            this.btnDefaultBlankImage.Name = "btnDefaultBlankImage";
            this.btnDefaultBlankImage.Size = new System.Drawing.Size(75, 23);
            this.btnDefaultBlankImage.TabIndex = 11;
            this.btnDefaultBlankImage.Text = "Select";
            this.btnDefaultBlankImage.UseVisualStyleBackColor = true;
            this.btnDefaultBlankImage.Click += new System.EventHandler(this.btnDefaultBlankImage_Click);
            // 
            // lblDefaultBlankImageFile
            // 
            this.lblDefaultBlankImageFile.AutoSize = true;
            this.lblDefaultBlankImageFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultBlankImageFile.Location = new System.Drawing.Point(25, 230);
            this.lblDefaultBlankImageFile.Name = "lblDefaultBlankImageFile";
            this.lblDefaultBlankImageFile.Size = new System.Drawing.Size(122, 13);
            this.lblDefaultBlankImageFile.TabIndex = 10;
            this.lblDefaultBlankImageFile.Text = "Default Blank Image";
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 337);
            this.Controls.Add(this.txtDefaultBlankImage);
            this.Controls.Add(this.btnDefaultBlankImage);
            this.Controls.Add(this.lblDefaultBlankImageFile);
            this.Controls.Add(this.txtLocalImageFolder);
            this.Controls.Add(this.btnLocalImageFolder);
            this.Controls.Add(this.lblTempImgFolder);
            this.Controls.Add(this.txtDefaultImageFileFolder);
            this.Controls.Add(this.btnSelectIfFolder);
            this.Controls.Add(this.lblImgFileFolder);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.lblPrintFileFolder);
            this.Controls.Add(this.txtDefaultPrintFileFolder);
            this.Controls.Add(this.btnSelectPfFolder);
            this.Name = "FrmSettings";
            this.Text = "PrintFile Maker Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectPfFolder;
        private System.Windows.Forms.TextBox txtDefaultPrintFileFolder;
        private System.Windows.Forms.Label lblPrintFileFolder;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label lblImgFileFolder;
        private System.Windows.Forms.TextBox txtDefaultImageFileFolder;
        private System.Windows.Forms.Button btnSelectIfFolder;
        private System.Windows.Forms.TextBox txtLocalImageFolder;
        private System.Windows.Forms.Button btnLocalImageFolder;
        private System.Windows.Forms.Label lblTempImgFolder;
        private System.Windows.Forms.TextBox txtDefaultBlankImage;
        private System.Windows.Forms.Button btnDefaultBlankImage;
        private System.Windows.Forms.Label lblDefaultBlankImageFile;
    }
}