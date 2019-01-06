using System;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class Verwaltung : Form
	{
		public Verwaltung()
		{
            InitializeComponent();

            // Muss unbedingt geändert werden!
            DB.LagerSQL.HoleAlleLager();
            DB.RegalSQL.HoleAlleRegale();
            DB.RegalfachSQL.HoleAlleRegalfach();
            DB.PaketSQL.HoleAllePakete();
            DB.ProduktSQL.HoleAlleProdukte();

            UpdateForm(Model.Lager.HoleListe);
		}

        private void ButtonRegalHinzufuegen_Click(object sender, System.EventArgs e)
        {
            using (var regalhinzufuegen = new RegalHinzufügen())
            {
                regalhinzufuegen.Owner = this;
                regalhinzufuegen.ShowDialog();
            }
        }

        private void ButtonLagerHinzufuegen_Click(object sender, System.EventArgs e)
        {
            using (var lagerhinzufuegen = new LagerHinzufuegen())
            {
                lagerhinzufuegen.Owner = this;
                lagerhinzufuegen.ShowDialog();
            }
        }

        private void ButtonPaketHinzufuegen_Click(object sender, System.EventArgs e)
        {
            using (var pakethinzufuegen = new PaketHinzufuegen())
            {
                pakethinzufuegen.Owner = this;
                pakethinzufuegen.ShowDialog();
            }
        }
        private void ButtonPaketEntfernen_Click(object sender, System.EventArgs e)
        {
            using (var paketentfernen = new PaketEntfernen())
            {
                paketentfernen.Owner = this;
                paketentfernen.ShowDialog();
            }
        }
        private void ButtonRegalEntfernen_Click(object sender, System.EventArgs e)
        {
            using (var regalaendern = new RegalAendern_Entfernen())
            {
                regalaendern.Owner = this;
                regalaendern.ShowDialog();
            }
        }
        private void ButtonLagerEntfernen_Click(object sender, System.EventArgs e)
        {
            using (var lagerentfernen = new LagerEntfernen())
            {
                lagerentfernen.Owner = this;
                lagerentfernen.ShowDialog();
            }
        }
        private void ButtonZurück_Click(object sender, System.EventArgs e)
        {
            Model.Lager.Reset();
            Model.Regal.Reset();
            Model.Regalfach.Reset();
            Model.Paket.Reset();
            Model.Produkt.Reset();
            Close();
        }

        private void ButtonPaketUmlagern_Click(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonLagerungOptimieren_Click(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }

		private void checkKompakt_CheckedChanged(object sender, EventArgs e)
		{
			UpdateForm(Model.Lager.HoleListe);
		}
	}
}
