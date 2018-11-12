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

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void buttonLagerHinzufügen_Click(object sender, EventArgs e)
		{
			Dashboard.LagerListe.Add(new Lager(0, this.textBoxLagerName.Text, 312, 312, new Core.Lagertyp(0, "Lagertyp", 12, 13), this.textBoxStandort.Text, this.textBoxBeschreibung.Text));
			Dashboard.Verwaltung.UpdateForm(Dashboard.LagerListe);
			this.Close();
		}
	}
}
