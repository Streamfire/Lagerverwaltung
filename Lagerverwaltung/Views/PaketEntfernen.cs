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

        private void ButtonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
