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
            throw new NotImplementedException();
        }
    }
}
