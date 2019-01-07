using System;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class Verwaltung : MetroFramework.Forms.MetroForm
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

        private void PaketHinzufuegenButton_Click(object sender, EventArgs e)
        {
            using (var pakethinzufuegen = new PaketHinzufuegen())
            {
                pakethinzufuegen.Owner = this;
                pakethinzufuegen.ShowDialog();
            }
        }

        private void PaketEntfernenButton_Click(object sender, EventArgs e)
        {
            using (var paketentfernen = new PaketEntfernen())
            {
                paketentfernen.Owner = this;
                paketentfernen.ShowDialog();
            }
        }

        private void PaketUmlagernButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RegalHinzufuegenButton_Click(object sender, EventArgs e)
        {
            using (var regalhinzufuegen = new RegalHinzufügen())
            {
                regalhinzufuegen.Owner = this;
                regalhinzufuegen.ShowDialog();
            }
        }

        private void LagerOptimierenButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LagerHinzufuegenButton_Click(object sender, EventArgs e)
        {
            using (var lagerhinzufuegen = new LagerHinzufuegen())
            {
                lagerhinzufuegen.Owner = this;
                lagerhinzufuegen.ShowDialog();
            }
        }

        private void LagerEntfernen_Click(object sender, EventArgs e)
        {
            using (var lagerentfernen = new LagerEntfernen())
            {
                lagerentfernen.Owner = this;
                lagerentfernen.ShowDialog();
            }
        }

        private void ForceCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateForm(Model.Lager.HoleListe);
        }

        private void ZurueckButton_Click(object sender, EventArgs e)
        {
            Model.Lager.Reset();
            Model.Regal.Reset();
            Model.Regalfach.Reset();
            Model.Paket.Reset();
            Model.Produkt.Reset();
            Close();
        }

        private void RegalAnpassenButton_Click(object sender, EventArgs e)
        {
            using (var regalaendern = new RegalAendern())
            {
                regalaendern.Owner = this;
                regalaendern.ShowDialog();
            }
        }
    }
}