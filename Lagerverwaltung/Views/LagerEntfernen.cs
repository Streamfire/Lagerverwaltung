using System;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class LagerEntfernen : Form
    {
        public LagerEntfernen()
        {
            InitializeComponent();
        }

        private void ButtonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonEntfernen_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
