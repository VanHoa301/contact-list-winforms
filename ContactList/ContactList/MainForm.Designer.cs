﻿namespace ContactList
{
    partial class MainForm
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
            label1 = new Label();
            btnThemlienhe = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(316, 58);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 0;
            label1.Text = "Danh sách liên hệ";
            label1.Click += label1_Click;
            // 
            // btnThemlienhe
            // 
            btnThemlienhe.Location = new Point(329, 98);
            btnThemlienhe.Name = "btnThemlienhe";
            btnThemlienhe.Size = new Size(153, 29);
            btnThemlienhe.TabIndex = 1;
            btnThemlienhe.Text = "Thêm liên hệ";
            btnThemlienhe.UseVisualStyleBackColor = true;
            btnThemlienhe.Click += btnThemlienhe_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThemlienhe);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnThemlienhe;
    }
}
