namespace Rutland.PrintFileMaker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabLayoutType = new System.Windows.Forms.TabControl();
            this.TabThirdSheet = new System.Windows.Forms.TabPage();
            this.lblLayoutText = new System.Windows.Forms.Label();
            this.pnlUniformStyle = new System.Windows.Forms.Panel();
            this.lblBottom = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.CbLayoutStyle = new System.Windows.Forms.ComboBox();
            this.lblSelectTsLayout = new System.Windows.Forms.Label();
            this.TabFiveByFive = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl5x5Bottom = new System.Windows.Forms.Label();
            this.lbl5x5Top = new System.Windows.Forms.Label();
            this.pnl5x5Bottom = new System.Windows.Forms.Panel();
            this.pnl5x5Top = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl5x5Layout = new System.Windows.Forms.Label();
            this.cmbSelect5x5Layout = new System.Windows.Forms.ComboBox();
            this.lblDefaultImage = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePrintFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMakePrintFile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImportSns = new System.Windows.Forms.Button();
            this.lblSnIndividual = new System.Windows.Forms.Label();
            this.txtSerialNumberList = new System.Windows.Forms.TextBox();
            this.lblSnStop = new System.Windows.Forms.Label();
            this.txtSnStop = new System.Windows.Forms.TextBox();
            this.lblSnStart = new System.Windows.Forms.Label();
            this.txtSnStart = new System.Windows.Forms.TextBox();
            this.lblSerialNumbers = new System.Windows.Forms.Label();
            this.lblControlPanel = new System.Windows.Forms.Label();
            this.lblDefaultImg = new System.Windows.Forms.Label();
            this.tabLayoutType.SuspendLayout();
            this.TabThirdSheet.SuspendLayout();
            this.pnlUniformStyle.SuspendLayout();
            this.TabFiveByFive.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLayoutType
            // 
            this.tabLayoutType.Controls.Add(this.TabThirdSheet);
            this.tabLayoutType.Controls.Add(this.TabFiveByFive);
            this.tabLayoutType.Location = new System.Drawing.Point(12, 42);
            this.tabLayoutType.Name = "tabLayoutType";
            this.tabLayoutType.SelectedIndex = 0;
            this.tabLayoutType.Size = new System.Drawing.Size(733, 561);
            this.tabLayoutType.TabIndex = 0;
            // 
            // TabThirdSheet
            // 
            this.TabThirdSheet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabThirdSheet.Controls.Add(this.lblLayoutText);
            this.TabThirdSheet.Controls.Add(this.pnlUniformStyle);
            this.TabThirdSheet.Controls.Add(this.CbLayoutStyle);
            this.TabThirdSheet.Controls.Add(this.lblSelectTsLayout);
            this.TabThirdSheet.Location = new System.Drawing.Point(4, 22);
            this.TabThirdSheet.Name = "TabThirdSheet";
            this.TabThirdSheet.Padding = new System.Windows.Forms.Padding(3);
            this.TabThirdSheet.Size = new System.Drawing.Size(725, 535);
            this.TabThirdSheet.TabIndex = 0;
            this.TabThirdSheet.Text = "ThirdSheet";
            // 
            // lblLayoutText
            // 
            this.lblLayoutText.AutoSize = true;
            this.lblLayoutText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLayoutText.Location = new System.Drawing.Point(535, 10);
            this.lblLayoutText.Name = "lblLayoutText";
            this.lblLayoutText.Size = new System.Drawing.Size(135, 24);
            this.lblLayoutText.TabIndex = 3;
            this.lblLayoutText.Text = "Uniform Layout";
            // 
            // pnlUniformStyle
            // 
            this.pnlUniformStyle.Controls.Add(this.lblBottom);
            this.pnlUniformStyle.Controls.Add(this.lblTop);
            this.pnlUniformStyle.Controls.Add(this.pnlBottom);
            this.pnlUniformStyle.Controls.Add(this.pnlTop);
            this.pnlUniformStyle.Location = new System.Drawing.Point(3, 39);
            this.pnlUniformStyle.Name = "pnlUniformStyle";
            this.pnlUniformStyle.Size = new System.Drawing.Size(716, 493);
            this.pnlUniformStyle.TabIndex = 2;
            // 
            // lblBottom
            // 
            this.lblBottom.AutoSize = true;
            this.lblBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBottom.Location = new System.Drawing.Point(515, 3);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(46, 13);
            this.lblBottom.TabIndex = 3;
            this.lblBottom.Text = "Bottom";
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(167, 3);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(29, 13);
            this.lblTop.TabIndex = 2;
            this.lblTop.Text = "Top";
            // 
            // pnlBottom
            // 
            this.pnlBottom.AutoScroll = true;
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBottom.Location = new System.Drawing.Point(363, 19);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(344, 460);
            this.pnlBottom.TabIndex = 1;
            // 
            // pnlTop
            // 
            this.pnlTop.AutoScroll = true;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Location = new System.Drawing.Point(14, 19);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(344, 460);
            this.pnlTop.TabIndex = 0;
            // 
            // CbLayoutStyle
            // 
            this.CbLayoutStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbLayoutStyle.FormattingEnabled = true;
            this.CbLayoutStyle.Items.AddRange(new object[] {
            "Uniform",
            "Top/Bottom",
            "Individual"});
            this.CbLayoutStyle.Location = new System.Drawing.Point(124, 10);
            this.CbLayoutStyle.Name = "CbLayoutStyle";
            this.CbLayoutStyle.Size = new System.Drawing.Size(121, 21);
            this.CbLayoutStyle.TabIndex = 1;
            this.CbLayoutStyle.SelectedIndexChanged += new System.EventHandler(this.CbLayoutStyle_SelectedIndexChanged);
            // 
            // lblSelectTsLayout
            // 
            this.lblSelectTsLayout.AutoSize = true;
            this.lblSelectTsLayout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTsLayout.Location = new System.Drawing.Point(15, 13);
            this.lblSelectTsLayout.Name = "lblSelectTsLayout";
            this.lblSelectTsLayout.Size = new System.Drawing.Size(98, 13);
            this.lblSelectTsLayout.TabIndex = 0;
            this.lblSelectTsLayout.Text = "Select Layout Style";
            // 
            // TabFiveByFive
            // 
            this.TabFiveByFive.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabFiveByFive.Controls.Add(this.panel1);
            this.TabFiveByFive.Controls.Add(this.label4);
            this.TabFiveByFive.Controls.Add(this.lbl5x5Layout);
            this.TabFiveByFive.Controls.Add(this.cmbSelect5x5Layout);
            this.TabFiveByFive.Location = new System.Drawing.Point(4, 22);
            this.TabFiveByFive.Name = "TabFiveByFive";
            this.TabFiveByFive.Padding = new System.Windows.Forms.Padding(3);
            this.TabFiveByFive.Size = new System.Drawing.Size(725, 535);
            this.TabFiveByFive.TabIndex = 1;
            this.TabFiveByFive.Text = "Five x Five";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl5x5Bottom);
            this.panel1.Controls.Add(this.lbl5x5Top);
            this.panel1.Controls.Add(this.pnl5x5Bottom);
            this.panel1.Controls.Add(this.pnl5x5Top);
            this.panel1.Location = new System.Drawing.Point(3, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 545);
            this.panel1.TabIndex = 6;
            // 
            // lbl5x5Bottom
            // 
            this.lbl5x5Bottom.AutoSize = true;
            this.lbl5x5Bottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5x5Bottom.Location = new System.Drawing.Point(515, 3);
            this.lbl5x5Bottom.Name = "lbl5x5Bottom";
            this.lbl5x5Bottom.Size = new System.Drawing.Size(46, 13);
            this.lbl5x5Bottom.TabIndex = 3;
            this.lbl5x5Bottom.Text = "Bottom";
            // 
            // lbl5x5Top
            // 
            this.lbl5x5Top.AutoSize = true;
            this.lbl5x5Top.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5x5Top.Location = new System.Drawing.Point(167, 3);
            this.lbl5x5Top.Name = "lbl5x5Top";
            this.lbl5x5Top.Size = new System.Drawing.Size(29, 13);
            this.lbl5x5Top.TabIndex = 2;
            this.lbl5x5Top.Text = "Top";
            // 
            // pnl5x5Bottom
            // 
            this.pnl5x5Bottom.AutoScroll = true;
            this.pnl5x5Bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl5x5Bottom.Location = new System.Drawing.Point(363, 19);
            this.pnl5x5Bottom.Name = "pnl5x5Bottom";
            this.pnl5x5Bottom.Size = new System.Drawing.Size(344, 460);
            this.pnl5x5Bottom.TabIndex = 1;
            // 
            // pnl5x5Top
            // 
            this.pnl5x5Top.AutoScroll = true;
            this.pnl5x5Top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl5x5Top.Location = new System.Drawing.Point(14, 19);
            this.pnl5x5Top.Name = "pnl5x5Top";
            this.pnl5x5Top.Size = new System.Drawing.Size(344, 460);
            this.pnl5x5Top.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Select Layout Style";
            // 
            // lbl5x5Layout
            // 
            this.lbl5x5Layout.AutoSize = true;
            this.lbl5x5Layout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5x5Layout.Location = new System.Drawing.Point(535, 10);
            this.lbl5x5Layout.Name = "lbl5x5Layout";
            this.lbl5x5Layout.Size = new System.Drawing.Size(135, 24);
            this.lbl5x5Layout.TabIndex = 7;
            this.lbl5x5Layout.Text = "Uniform Layout";
            // 
            // cmbSelect5x5Layout
            // 
            this.cmbSelect5x5Layout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelect5x5Layout.FormattingEnabled = true;
            this.cmbSelect5x5Layout.Items.AddRange(new object[] {
            "Uniform",
            "By Row",
            "Individual"});
            this.cmbSelect5x5Layout.Location = new System.Drawing.Point(124, 10);
            this.cmbSelect5x5Layout.Name = "cmbSelect5x5Layout";
            this.cmbSelect5x5Layout.Size = new System.Drawing.Size(121, 21);
            this.cmbSelect5x5Layout.TabIndex = 5;
            this.cmbSelect5x5Layout.SelectedIndexChanged += new System.EventHandler(this.cmbSelect5x5Layout_SelectedIndexChanged);
            // 
            // lblDefaultImage
            // 
            this.lblDefaultImage.AutoSize = true;
            this.lblDefaultImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultImage.Location = new System.Drawing.Point(7, 623);
            this.lblDefaultImage.Name = "lblDefaultImage";
            this.lblDefaultImage.Size = new System.Drawing.Size(110, 20);
            this.lblDefaultImage.TabIndex = 4;
            this.lblDefaultImage.Text = "Default Image";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePrintFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // savePrintFileToolStripMenuItem
            // 
            this.savePrintFileToolStripMenuItem.Name = "savePrintFileToolStripMenuItem";
            this.savePrintFileToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.savePrintFileToolStripMenuItem.Text = "Save Print File";
            this.savePrintFileToolStripMenuItem.Click += new System.EventHandler(this.savePrintFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnMakePrintFile
            // 
            this.btnMakePrintFile.Location = new System.Drawing.Point(610, 622);
            this.btnMakePrintFile.Name = "btnMakePrintFile";
            this.btnMakePrintFile.Size = new System.Drawing.Size(109, 23);
            this.btnMakePrintFile.TabIndex = 7;
            this.btnMakePrintFile.Text = "Make PrintFile";
            this.btnMakePrintFile.UseVisualStyleBackColor = true;
            this.btnMakePrintFile.Click += new System.EventHandler(this.btnMakePrintFile_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnImportSns);
            this.panel2.Controls.Add(this.lblSnIndividual);
            this.panel2.Controls.Add(this.txtSerialNumberList);
            this.panel2.Controls.Add(this.lblSnStop);
            this.panel2.Controls.Add(this.txtSnStop);
            this.panel2.Controls.Add(this.lblSnStart);
            this.panel2.Controls.Add(this.txtSnStart);
            this.panel2.Controls.Add(this.lblSerialNumbers);
            this.panel2.Controls.Add(this.lblControlPanel);
            this.panel2.Location = new System.Drawing.Point(752, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 603);
            this.panel2.TabIndex = 8;
            // 
            // btnImportSns
            // 
            this.btnImportSns.Location = new System.Drawing.Point(15, 566);
            this.btnImportSns.Name = "btnImportSns";
            this.btnImportSns.Size = new System.Drawing.Size(191, 23);
            this.btnImportSns.TabIndex = 8;
            this.btnImportSns.Text = "Import Serial Numbers from File";
            this.btnImportSns.UseVisualStyleBackColor = true;
            this.btnImportSns.Click += new System.EventHandler(this.btnImportSns_Click);
            // 
            // lblSnIndividual
            // 
            this.lblSnIndividual.AutoSize = true;
            this.lblSnIndividual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnIndividual.Location = new System.Drawing.Point(12, 122);
            this.lblSnIndividual.Name = "lblSnIndividual";
            this.lblSnIndividual.Size = new System.Drawing.Size(62, 13);
            this.lblSnIndividual.TabIndex = 7;
            this.lblSnIndividual.Text = "Individual";
            // 
            // txtSerialNumberList
            // 
            this.txtSerialNumberList.Location = new System.Drawing.Point(15, 138);
            this.txtSerialNumberList.Multiline = true;
            this.txtSerialNumberList.Name = "txtSerialNumberList";
            this.txtSerialNumberList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSerialNumberList.Size = new System.Drawing.Size(191, 422);
            this.txtSerialNumberList.TabIndex = 6;
            // 
            // lblSnStop
            // 
            this.lblSnStop.AutoSize = true;
            this.lblSnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnStop.Location = new System.Drawing.Point(12, 84);
            this.lblSnStop.Name = "lblSnStop";
            this.lblSnStop.Size = new System.Drawing.Size(48, 13);
            this.lblSnStop.TabIndex = 5;
            this.lblSnStop.Text = "End with";
            // 
            // txtSnStop
            // 
            this.txtSnStop.Location = new System.Drawing.Point(66, 81);
            this.txtSnStop.Name = "txtSnStop";
            this.txtSnStop.Size = new System.Drawing.Size(140, 20);
            this.txtSnStop.TabIndex = 4;
            // 
            // lblSnStart
            // 
            this.lblSnStart.AutoSize = true;
            this.lblSnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnStart.Location = new System.Drawing.Point(12, 58);
            this.lblSnStart.Name = "lblSnStart";
            this.lblSnStart.Size = new System.Drawing.Size(51, 13);
            this.lblSnStart.TabIndex = 3;
            this.lblSnStart.Text = "Start with";
            // 
            // txtSnStart
            // 
            this.txtSnStart.Location = new System.Drawing.Point(66, 55);
            this.txtSnStart.Name = "txtSnStart";
            this.txtSnStart.Size = new System.Drawing.Size(140, 20);
            this.txtSnStart.TabIndex = 2;
            // 
            // lblSerialNumbers
            // 
            this.lblSerialNumbers.AutoSize = true;
            this.lblSerialNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNumbers.Location = new System.Drawing.Point(12, 40);
            this.lblSerialNumbers.Name = "lblSerialNumbers";
            this.lblSerialNumbers.Size = new System.Drawing.Size(44, 13);
            this.lblSerialNumbers.TabIndex = 1;
            this.lblSerialNumbers.Text = "Range";
            // 
            // lblControlPanel
            // 
            this.lblControlPanel.AutoSize = true;
            this.lblControlPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlPanel.Location = new System.Drawing.Point(48, 9);
            this.lblControlPanel.Name = "lblControlPanel";
            this.lblControlPanel.Size = new System.Drawing.Size(131, 20);
            this.lblControlPanel.TabIndex = 0;
            this.lblControlPanel.Text = "Serial Numbers";
            // 
            // lblDefaultImg
            // 
            this.lblDefaultImg.AutoSize = true;
            this.lblDefaultImg.Location = new System.Drawing.Point(124, 629);
            this.lblDefaultImg.Name = "lblDefaultImg";
            this.lblDefaultImg.Size = new System.Drawing.Size(0, 13);
            this.lblDefaultImg.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 661);
            this.Controls.Add(this.lblDefaultImg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnMakePrintFile);
            this.Controls.Add(this.tabLayoutType);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblDefaultImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PrintFileMaker";
            this.tabLayoutType.ResumeLayout(false);
            this.TabThirdSheet.ResumeLayout(false);
            this.TabThirdSheet.PerformLayout();
            this.pnlUniformStyle.ResumeLayout(false);
            this.pnlUniformStyle.PerformLayout();
            this.TabFiveByFive.ResumeLayout(false);
            this.TabFiveByFive.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabLayoutType;
        private System.Windows.Forms.TabPage TabThirdSheet;
        private System.Windows.Forms.TabPage TabFiveByFive;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ComboBox CbLayoutStyle;
        private System.Windows.Forms.Label lblSelectTsLayout;
        private System.Windows.Forms.Panel pnlUniformStyle;
        private System.Windows.Forms.Label lblBottom;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblDefaultImage;
        private System.Windows.Forms.Label lblLayoutText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl5x5Bottom;
        private System.Windows.Forms.Label lbl5x5Top;
        private System.Windows.Forms.Panel pnl5x5Bottom;
        private System.Windows.Forms.Panel pnl5x5Top;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl5x5Layout;
        private System.Windows.Forms.ComboBox cmbSelect5x5Layout;
        private System.Windows.Forms.Button btnMakePrintFile;
        private System.Windows.Forms.ToolStripMenuItem savePrintFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSnStop;
        private System.Windows.Forms.TextBox txtSnStop;
        private System.Windows.Forms.Label lblSnStart;
        private System.Windows.Forms.TextBox txtSnStart;
        private System.Windows.Forms.Label lblSerialNumbers;
        private System.Windows.Forms.Label lblControlPanel;
        private System.Windows.Forms.TextBox txtSerialNumberList;
        private System.Windows.Forms.Label lblSnIndividual;
        private System.Windows.Forms.Button btnImportSns;
        public System.Windows.Forms.Label lblDefaultImg;
    }
}

