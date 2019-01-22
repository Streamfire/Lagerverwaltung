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
    public partial class NutzerHinzufuegen : MetroFramework.Forms.MetroForm
    {
        public NutzerHinzufuegen()
        {
            InitializeComponent();
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextbox.UseSystemPasswordChar = !PasswordTextbox.UseSystemPasswordChar;
            PasswordTextbox.PasswordChar = char.MinValue;
            ConfirmPasswordTextbox.UseSystemPasswordChar = !ConfirmPasswordTextbox.UseSystemPasswordChar;
            ConfirmPasswordTextbox.PasswordChar = char.MinValue;
        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            string vorname = VornameTextbox.Text;
            string nachname = NachnameTextbox.Text;
            string username = UsernameTextbox.Text;
            string password = PasswordTextbox.Text;
            string confirmpw = ConfirmPasswordTextbox.Text;

            if (string.IsNullOrWhiteSpace(vorname) || string.IsNullOrWhiteSpace(nachname) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmpw))
            {
                MetroFramework.MetroMessageBox.Show(this,"Bitte alle Felder ausfüllen","Ungültige Eingaben!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if(password != confirmpw)
            {
                MetroFramework.MetroMessageBox.Show(this, "Passwörter ungleich!", "Ungültige Eingaben!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string salt = Controller.AuthenticationController.Create_Salt(10);
            string newpw = Controller.AuthenticationController.GeneratePasswordHash(password,salt);

            if (username.Length > 10 || vorname.Length > 20 || nachname.Length > 20 || password.Length > 40 || confirmpw.Length > 40)
            {
                MetroFramework.MetroMessageBox.Show(this, "Eingaben sind zu lang! Limits: Benutzername: 10 Zeichen, Name/Vorname: 20 Zeichen, Passwort: 40 Zeichen!", "Zu lange Eingaben!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DB.SqlStatements.ErstelleUser(vorname, nachname, username, newpw, salt);
                MetroFramework.MetroMessageBox.Show(this,"Neuen Nutzer erfolgreich angelegt","Erfolgreich!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Close();
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Datenbankfehler: Eingabe(n) zu lang!", "Ungültige Eingaben!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
