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
			Dashboard.LagerListe.Add(new Core.Lager(0, this.textBoxLagerName.Text, this.textBoxStandort.Text, this.textBoxBeschreibung.Text, 312, 312, new Core.Lagertyp(0, "Lagertyp", 12, 13)));
			Dashboard.Verwaltung.UpdateForm(Dashboard.LagerListe);
			this.Close();
		}
	}
}
