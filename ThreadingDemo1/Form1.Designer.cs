﻿namespace ThreadingDemo1
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
            btnProccess1 = new Button();
            btnProccess2 = new Button();
            SuspendLayout();
            // 
            // btnProccess1
            // 
            btnProccess1.Location = new Point(35, 43);
            btnProccess1.Name = "btnProccess1";
            btnProccess1.Size = new Size(131, 33);
            btnProccess1.TabIndex = 0;
            btnProccess1.Text = "button1";
            btnProccess1.UseVisualStyleBackColor = true;
            btnProccess1.Click += btnProccess1_Click;
            // 
            // btnProccess2
            // 
            btnProccess2.Location = new Point(35, 82);
            btnProccess2.Name = "btnProccess2";
            btnProccess2.Size = new Size(131, 33);
            btnProccess2.TabIndex = 1;
            btnProccess2.Text = "button2";
            btnProccess2.UseVisualStyleBackColor = true;
            btnProccess2.Click += btnProccess2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 252);
            Controls.Add(btnProccess2);
            Controls.Add(btnProccess1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProccess1;
        private Button btnProccess2;
    }
}
