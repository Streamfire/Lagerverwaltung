using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class PasswortAendern : MetroFramework.Forms.MetroForm
    {
        public PasswortAendern()
        {
            InitializeComponent();
            
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(NewPasswordTextbox.Text != ConfirmNewTextbox.Text)
            {
                MetroFramework.MetroMessageBox.Show(this, "Passwörter stimmen nicht überein!", "Passwortänderung fehlgeschlagen!", MessageBoxButtons.OK, MessageBoxIcon.Information, 125);
            }
            else if (Lagerverwaltung.Controller.AuthenticationController.Login(NutzernameTextbox.Text, OldPasswordTextbox.Text))         
            {
                try
                {
                    //Erstellung Salt + Passwordhash und update in Database
                    string temp_salt = Lagerverwaltung.Controller.AuthenticationController.Create_Salt(10);
                    DB.UserSQL.UpdateUserPassword(NutzernameTextbox.Text, Lagerverwaltung.Controller.AuthenticationController.GeneratePasswordHash(NewPasswordTextbox.Text, temp_salt), temp_salt);
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this,"Bitte vorher die PostgreSQL Datenbank starten!", "Keine Verbindung!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                Close();
            }
            else
                MetroFramework.MetroMessageBox.Show(this,"Der Nutzername oder das Passwort sind ungültig!", "Passwortänderung fehlgeschlagen!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            OldPasswordTextbox.UseSystemPasswordChar = !OldPasswordTextbox.UseSystemPasswordChar;
            OldPasswordTextbox.PasswordChar = char.MinValue;
            NewPasswordTextbox.UseSystemPasswordChar = !NewPasswordTextbox.UseSystemPasswordChar;
            NewPasswordTextbox.PasswordChar = char.MinValue;
            ConfirmNewTextbox.UseSystemPasswordChar = !ConfirmNewTextbox.UseSystemPasswordChar;
            ConfirmNewTextbox.PasswordChar = char.MinValue;
        }
    }
}
