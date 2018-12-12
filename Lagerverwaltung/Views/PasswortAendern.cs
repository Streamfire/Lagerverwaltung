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
    public partial class PasswortAendern : Form
    {
        public PasswortAendern()
        {
            InitializeComponent();
            
        }

        private void ButtonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonOkay_Click(object sender, EventArgs e)
        {
            if (Lagerverwaltung.Controller.AuthenticationController.Login(textBoxNutzername.Text, textBoxAltesPasswort.Text))
            {
                try
                {
                    //Erstellung Salt + Passwordhash und update in Database
                    string temp_salt = Lagerverwaltung.Controller.AuthenticationController.Create_Salt(10);
                    DB.UserSQL.UpdateUserPassword(textBoxNutzername.Text, Lagerverwaltung.Controller.AuthenticationController.GeneratePasswordHash(textBoxNeuesPasswort.Text, temp_salt), temp_salt);
                }
                catch
                {
                    MessageBox.Show("Bitte vorher die PostgreSQL Datenbank starten!", "Keine Verbindung!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                Close();
            }
            else
                MessageBox.Show("Der Nutzername oder das Passwort sind ungültig!", "Passwortänderung fehlgeschlagen!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

    }
}
