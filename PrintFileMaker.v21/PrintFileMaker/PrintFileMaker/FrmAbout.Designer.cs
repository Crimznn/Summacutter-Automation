﻿namespace Rutland.PrintFileMaker
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Print File Maker";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(3, 135);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(29, 13);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "label";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(169, 192);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(141, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.rutlandcorp.com";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 214);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmAbout";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
    }
}