using System;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
   
    public partial class Login : Form
	{
        private string _username = "admin";
        private string _userpass = "admin";
        private static bool _adminuser = false;

        public Login()
		{
			InitializeComponent();
		}
        public static PasswortAendern PasswortAendern { get => _passwortAendern; set => _passwortAendern = value; }
        
        private static PasswortAendern _passwortAendern = null;
        
        /// <summary>
        /// Get Methode um zu bestimmen ob der Nutzer beim Login richtig lag.
        /// </summary>
        public bool Adminuser { get => _adminuser; }

		//Login Button gedrückt
		private void Button1_Click(object sender, EventArgs e)
		{
            if (Controller.AuthenticationController.Login(textBox1.Text, textBox2.Text)) 
			{
				_adminuser = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
			}
			else
			{
				label4.Text = "Nutzername oder Passwort falsch.";
				_adminuser = false;
			}
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			_adminuser = false;
            this.DialogResult = DialogResult.OK;
			this.Close();
		}

        private void buttonPasswortAendern_Click(object sender, EventArgs e)
        {
            if (PasswortAendern != null)
            {
                PasswortAendern.ShowDialog(this);

            }
            else
            {
                PasswortAendern = new PasswortAendern();
                PasswortAendern.ShowDialog();
            }
        }

       
    }
}
