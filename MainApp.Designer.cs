﻿namespace PaintDrawX
{
    partial class MainApp
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
            this.SuspendLayout();
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "MainApp";
            this.Text = "Excalibur Sword in GDI+";
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainApp_Paint);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

