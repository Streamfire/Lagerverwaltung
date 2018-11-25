using System;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class PaketEntfernen : Form
    {
        public PaketEntfernen()
        {
            InitializeComponent();
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
