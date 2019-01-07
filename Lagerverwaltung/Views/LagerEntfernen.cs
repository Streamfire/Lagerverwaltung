using System;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class LagerEntfernen : MetroFramework.Forms.MetroForm
    {
        public LagerEntfernen()
        {
            InitializeComponent();
        }

        private void AbbrechenButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HinzufuegenButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}