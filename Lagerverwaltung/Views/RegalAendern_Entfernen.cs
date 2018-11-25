using System;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class RegalAendern_Entfernen : Form
    {
        public RegalAendern_Entfernen()
        {
            InitializeComponent();
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
