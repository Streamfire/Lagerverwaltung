using System;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
   
    public partial class Login : MetroFramework.Forms.MetroForm
	{
        public Login()
		{
			InitializeComponent();
		}

		//Login Button gedrückt
		private void LoginButton_Click(object sender, EventArgs e)
		{
            if (Controller.AuthenticationController.Login(UsernameTextbox.Text, PasswordTextbox.Text)) 
			{
                Controller.AuthenticationController.Adminuser = true;
                DialogResult = DialogResult.OK;
                Close();
			}
			else
			{
				ErrorLabel.Text = "Nutzername oder Passwort falsch.";
                ErrorLabel.Visible = true;
                Controller.AuthenticationController.Adminuser = false;
            }
		}

		private void GastButton_Click(object sender, EventArgs e)
		{
            Controller.AuthenticationController.Adminuser = false;
            DialogResult = DialogResult.OK;
			Close();
		}

        private void PasswortAendernButton_Click(object sender, EventArgs e)
        {
            using (var passwortaendern = new PasswortAendern())
            {
                passwortaendern.ShowDialog();
            }
        }

        private void ShowPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextbox.UseSystemPasswordChar = !PasswordTextbox.UseSystemPasswordChar;
            PasswordTextbox.PasswordChar = char.MinValue; // kleiner Bugfix
        }
    }
}
