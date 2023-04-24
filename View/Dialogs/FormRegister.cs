﻿using Optimum_Tech.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimum_Tech.Forms.Dialogs
{
    public partial class FormRegister : Form
    {
        private FormAccount formAccount;
        private FormMain formMain;
        public FormRegister(FormAccount formAccount, FormMain formMain)
        {
            InitializeComponent();

            this.formAccount = formAccount;
            this.formMain = formMain;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (UserManager.Register(textBoxLogin.Text, textBoxPassword.Text))
            {
                UserManager.Login(textBoxLogin, textBoxPassword);
                UserManager.UpdateStatus(formAccount._textBoxStatus);
                this.Close();
            }
        }

        public void CreateUser(string login, string password)
        {

        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.Text = "";
        }

        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Login")
            {
                textBoxLogin.Text = "";
            }
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text))
            {
                textBoxLogin.Text = "Login";
            }
        }
    }
}