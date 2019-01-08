using System;
using System.Windows.Forms;
using System.Linq;

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
                var user = DB.SqlStatements.HoleUser(username:UsernameTextbox.Text);
                Controller.AuthenticationController.GlobalUser =user.First().Value;
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
            Controller.AuthenticationController.GlobalUser = new Model.UserModel();
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
