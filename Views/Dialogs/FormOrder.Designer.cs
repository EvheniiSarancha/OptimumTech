﻿using Optimum_Tech.Forms.Dialogs;
using Optimum_Tech.Views.Resources;

namespace Optimum_Tech.Views.Dialogs
{
    partial class FormOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            textBoxOrder = new TextBox();
            pictureBoxClose = new PictureBox();
            panelTitle = new Panel();
            listBoxProducts = new ListBox();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            radioButtonAtPost = new RadioButton();
            radioButtonAtAddress = new RadioButton();
            buttonConfirm = new Button();
            textBoxPrice = new TextBox();
            textBoxAmount = new TextBox();
            panel1 = new Panel();
            panel3 = new Panel();
            textBoxId = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panelTitle.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxOrder
            // 
            textBoxOrder.BackColor = Color.FromArgb(20, 20, 20);
            textBoxOrder.BorderStyle = BorderStyle.None;
            textBoxOrder.Font = new Font("Poppins", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOrder.ForeColor = Color.White;
            textBoxOrder.Location = new Point(12, 1);
            textBoxOrder.Name = "textBoxOrder";
            textBoxOrder.ReadOnly = true;
            textBoxOrder.Size = new Size(729, 26);
            textBoxOrder.TabIndex = 0;
            textBoxOrder.TabStop = false;
            textBoxOrder.Text = "Order";
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxClose.Image = FormsMedia.close;
            pictureBoxClose.Location = new Point(747, 0);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(23, 25);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxClose.TabIndex = 1;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(20, 20, 20);
            panelTitle.Controls.Add(textBoxOrder);
            panelTitle.Controls.Add(pictureBoxClose);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(772, 28);
            panelTitle.TabIndex = 2;
            // 
            // listBoxProducts
            // 
            listBoxProducts.BackColor = Color.White;
            listBoxProducts.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 15;
            listBoxProducts.Location = new Point(473, 108);
            listBoxProducts.Margin = new Padding(3, 3, 23, 3);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(287, 199);
            listBoxProducts.Sorted = true;
            listBoxProducts.TabIndex = 4;
            // 
            // textBoxPhone
            // 
            textBoxPhone.BackColor = Color.White;
            textBoxPhone.BorderStyle = BorderStyle.None;
            textBoxPhone.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhone.Location = new Point(147, 162);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(237, 24);
            textBoxPhone.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.White;
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(71, 108);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(313, 24);
            textBoxEmail.TabIndex = 8;
            // 
            // radioButtonAtPost
            // 
            radioButtonAtPost.AutoSize = true;
            radioButtonAtPost.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonAtPost.ForeColor = Color.White;
            radioButtonAtPost.Location = new Point(12, 250);
            radioButtonAtPost.Name = "radioButtonAtPost";
            radioButtonAtPost.Size = new Size(144, 29);
            radioButtonAtPost.TabIndex = 10;
            radioButtonAtPost.Text = "Local post office";
            radioButtonAtPost.UseVisualStyleBackColor = true;
            radioButtonAtPost.CheckedChanged += radioButtonAtPost_CheckedChanged;
            // 
            // radioButtonAtAddress
            // 
            radioButtonAtAddress.AutoSize = true;
            radioButtonAtAddress.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonAtAddress.ForeColor = Color.White;
            radioButtonAtAddress.Location = new Point(12, 284);
            radioButtonAtAddress.Name = "radioButtonAtAddress";
            radioButtonAtAddress.Size = new Size(130, 29);
            radioButtonAtAddress.TabIndex = 11;
            radioButtonAtAddress.Text = "At the address";
            radioButtonAtAddress.UseVisualStyleBackColor = true;
            radioButtonAtAddress.CheckedChanged += radioButtonAtAddress_CheckedChanged;
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = Color.White;
            buttonConfirm.FlatAppearance.BorderSize = 0;
            buttonConfirm.FlatStyle = FlatStyle.Flat;
            buttonConfirm.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfirm.Location = new Point(676, 203);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(84, 33);
            buttonConfirm.TabIndex = 18;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = false;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = Color.White;
            textBoxPrice.BorderStyle = BorderStyle.None;
            textBoxPrice.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPrice.Location = new Point(557, 30);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(203, 24);
            textBoxPrice.TabIndex = 20;
            // 
            // textBoxAmount
            // 
            textBoxAmount.BackColor = Color.White;
            textBoxAmount.BorderStyle = BorderStyle.None;
            textBoxAmount.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAmount.Location = new Point(557, 0);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.ReadOnly = true;
            textBoxAmount.Size = new Size(203, 24);
            textBoxAmount.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBoxPhone);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(listBoxProducts);
            panel1.Controls.Add(radioButtonAtAddress);
            panel1.Controls.Add(radioButtonAtPost);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(772, 313);
            panel1.TabIndex = 30;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(textBoxId);
            panel3.Location = new Point(12, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(748, 29);
            panel3.TabIndex = 36;
            // 
            // textBoxId
            // 
            textBoxId.BackColor = Color.White;
            textBoxId.BorderStyle = BorderStyle.None;
            textBoxId.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxId.ForeColor = Color.Black;
            textBoxId.Location = new Point(12, 3);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(748, 24);
            textBoxId.TabIndex = 0;
            textBoxId.Text = "Order id:";
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.FromArgb(40, 40, 40);
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.ForeColor = Color.Gray;
            textBox9.Location = new Point(12, 192);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(269, 18);
            textBox9.TabIndex = 35;
            textBox9.Text = "Format: +380689998877";
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.FromArgb(40, 40, 40);
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.ForeColor = Color.Gray;
            textBox8.Location = new Point(12, 138);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(269, 18);
            textBox8.TabIndex = 34;
            textBox8.Text = "Format: user123@mail.com";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(40, 40, 40);
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Poppins SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.ForeColor = Color.White;
            textBox7.Location = new Point(12, 216);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 28);
            textBox7.TabIndex = 33;
            textBox7.Text = "Deliver to";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(40, 40, 40);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Poppins SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(473, 73);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(287, 28);
            textBox4.TabIndex = 32;
            textBox4.Text = "Products";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(40, 40, 40);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Poppins SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(12, 72);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(212, 28);
            textBox3.TabIndex = 31;
            textBox3.Text = "Fill in order data";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(40, 40, 40);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(12, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 24);
            textBox2.TabIndex = 30;
            textBox2.Text = "Phone number:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(40, 40, 40);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(12, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(53, 24);
            textBox1.TabIndex = 23;
            textBox1.Text = "Email:";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(buttonConfirm);
            panel2.Controls.Add(textBoxAmount);
            panel2.Controls.Add(textBoxPrice);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 313);
            panel2.Name = "panel2";
            panel2.Size = new Size(772, 248);
            panel2.TabIndex = 31;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(40, 40, 40);
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.ForeColor = Color.White;
            textBox6.Location = new Point(473, 30);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(78, 24);
            textBox6.TabIndex = 34;
            textBox6.Text = "Price:";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(40, 40, 40);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(473, 0);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(78, 24);
            textBox5.TabIndex = 33;
            textBox5.Text = "Amount:";
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(772, 561);
            Controls.Add(panelTitle);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order";
            Load += FormOrder_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxOrder;
        private PictureBox pictureBoxClose;
        private Panel panelTitle;
        private ListBox listBoxProducts;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private RadioButton radioButtonAtPost;
        private RadioButton radioButtonAtAddress;
        private Button buttonConfirm;
        private TextBox textBoxPrice;
        private TextBox textBoxAmount;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox7;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox9;
        private TextBox textBox8;
        private Panel panel3;
        private TextBox textBoxId;
    }
}