﻿namespace Optimum_Tech.Forms
{
    partial class FormFavorites
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel5 = new Panel();
            textBoxAccountPrefferences = new TextBox();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5, 40, 5, 5);
            flowLayoutPanel1.Size = new Size(1064, 735);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 30, 30);
            panel5.Controls.Add(textBoxAccountPrefferences);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1064, 34);
            panel5.TabIndex = 10;
            // 
            // textBoxAccountPrefferences
            // 
            textBoxAccountPrefferences.BackColor = Color.FromArgb(30, 30, 30);
            textBoxAccountPrefferences.BorderStyle = BorderStyle.None;
            textBoxAccountPrefferences.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAccountPrefferences.ForeColor = Color.White;
            textBoxAccountPrefferences.Location = new Point(12, 5);
            textBoxAccountPrefferences.Name = "textBoxAccountPrefferences";
            textBoxAccountPrefferences.ReadOnly = true;
            textBoxAccountPrefferences.Size = new Size(245, 26);
            textBoxAccountPrefferences.TabIndex = 4;
            textBoxAccountPrefferences.Text = "Favorites";
            // 
            // FormFavorites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 735);
            Controls.Add(panel5);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFavorites";
            Text = "FormFavorites";
            Load += FormFavorites_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        internal FlowLayoutPanel flowLayoutPanel1;
        private Panel panel5;
        private TextBox textBoxAccountPrefferences;
    }
}