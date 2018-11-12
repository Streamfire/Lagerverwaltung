using System;
using System.Windows.Forms;
using Lagerverwaltung.Core;

namespace Lagerverwaltung.Views
{
    public partial class LagerHinzufuegen : Form
    {
        public LagerHinzufuegen()
        {
            InitializeComponent();
        }

        private void ButtonAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void ButtonLagerHinzufügen_Click(object sender, EventArgs e)
		{
			Dashboard.LagerListe.Add(new Lager(0, this.textBoxLagerName.Text, new DateTime(), new DateTime(), 0, this.textBoxStandort.Text, this.textBoxBeschreibung.Text));
			Dashboard.Verwaltung.UpdateForm(Dashboard.LagerListe);
			this.Close();
		}
	}
}
