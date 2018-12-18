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
    public partial class NutzerHinzufuegen : Form
    {
        public NutzerHinzufuegen()
        {
            InitializeComponent();
        }
        private void ButtonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonNutzerAnlegen_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void show_cleartext_Click(object sender, EventArgs e)
        {
            textBoxPasswort.UseSystemPasswordChar = !textBoxPasswort.UseSystemPasswordChar;
            textBoxPasswortBestaetigen.UseSystemPasswordChar = !textBoxPasswortBestaetigen.UseSystemPasswordChar;
        }
    }
}
