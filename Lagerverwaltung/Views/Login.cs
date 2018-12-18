﻿using System;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
   
    public partial class Login : Form
	{
        public Login()
		{
			InitializeComponent();
		}

		//Login Button gedrückt
		private void Button1_Click(object sender, EventArgs e)
		{
            if (Controller.AuthenticationController.Login(textBox1.Text, textBox2.Text)) 
			{
                Controller.AuthenticationController.Adminuser = true;
                DialogResult = DialogResult.OK;
                Close();
			}
			else
			{
				label4.Text = "Nutzername oder Passwort falsch.";
                label4.Visible = true;
                Controller.AuthenticationController.Adminuser = false;
            }
		}

		private void Button2_Click(object sender, EventArgs e)
		{
            Controller.AuthenticationController.Adminuser = false;
            DialogResult = DialogResult.OK;
			Close();
		}

        private void ButtonPasswortAendern_Click(object sender, EventArgs e)
        {
            using (var passwortaendern = new PasswortAendern())
            {
                passwortaendern.ShowDialog();
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
        }
    }
}
