﻿namespace WindowsFormsApp2
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
            this.userCalender1 = new WindowsFormsApp2.UserCalender();
            this.SuspendLayout();
            // 
            // userCalender1
            // 
            this.userCalender1.Location = new System.Drawing.Point(15, 15);
            this.userCalender1.Margin = new System.Windows.Forms.Padding(6);
            this.userCalender1.Name = "userCalender1";
            this.userCalender1.Size = new System.Drawing.Size(792, 910);
            this.userCalender1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 942);
            this.Controls.Add(this.userCalender1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(847, 1013);
            this.MinimumSize = new System.Drawing.Size(847, 1013);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserCalender userCalender1;
    }
}

