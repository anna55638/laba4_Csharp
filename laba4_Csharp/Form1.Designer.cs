﻿namespace laba4_Csharp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRefill = new Button();
            txtInfo = new RichTextBox();
            txtOut = new RichTextBox();
            btnGet = new Button();
            SuspendLayout();
            // 
            // btnRefill
            // 
            btnRefill.Location = new Point(104, 23);
            btnRefill.Name = "btnRefill";
            btnRefill.Size = new Size(201, 29);
            btnRefill.TabIndex = 0;
            btnRefill.Text = "button1";
            btnRefill.UseVisualStyleBackColor = true;
            // 
            // txtInfo
            // 
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Location = new Point(104, 58);
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(201, 47);
            txtInfo.TabIndex = 1;
            txtInfo.Text = "";
            // 
            // txtOut
            // 
            txtOut.BorderStyle = BorderStyle.None;
            txtOut.Location = new Point(104, 111);
            txtOut.Name = "txtOut";
            txtOut.ReadOnly = true;
            txtOut.Size = new Size(122, 59);
            txtOut.TabIndex = 2;
            txtOut.Text = "";
            // 
            // btnGet
            // 
            btnGet.Location = new Point(232, 111);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(73, 59);
            btnGet.TabIndex = 3;
            btnGet.Text = "button1";
            btnGet.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(461, 336);
            Controls.Add(btnGet);
            Controls.Add(txtOut);
            Controls.Add(txtInfo);
            Controls.Add(btnRefill);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefill;
        private RichTextBox txtInfo;
        private RichTextBox txtOut;
        private Button btnGet;
    }
}
