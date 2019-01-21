using System;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class Verwaltung : MetroFramework.Forms.MetroForm
	{
		public Verwaltung()
		{
            InitializeComponent();

            PaketHinzufuegenButton.Visible = false;
            PaketEntfernenButton.Visible = false;
            PaketUmlagernButton.Visible = false;
            LagerOptimierenButton.Visible = false;


            LagerHinzufuegenButton.Location = RegalHinzufuegenButton.Location;
            LagerEntfernen.Location = RegalAnpassenButton.Location;
            RegalHinzufuegenButton.Location = PaketHinzufuegenButton.Location;
            RegalAnpassenButton.Location = PaketEntfernenButton.Location;

			UpdateForm();
		}

        private void PaketHinzufuegenButton_Click(object sender, EventArgs e)
        {
            /*
            using (var pakethinzufuegen = new PaketHinzufuegen())
            {
                pakethinzufuegen.Owner = this;
                pakethinzufuegen.ShowDialog();
            }*/
        }

        private void PaketEntfernenButton_Click(object sender, EventArgs e)
        {
            /*
            using (var paketentfernen = new PaketEntfernen())
            {
                paketentfernen.Owner = this;
                paketentfernen.ShowDialog();
            }*/
        }

        private void PaketUmlagernButton_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void RegalHinzufuegenButton_Click(object sender, EventArgs e)
        {
            using (var regalhinzufuegen = new RegalHinzufuegen())
            {
                regalhinzufuegen.Besitzer = this;
                regalhinzufuegen.Owner = this;
                regalhinzufuegen.ShowDialog();
            }
        }

        private void LagerOptimierenButton_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void LagerHinzufuegenButton_Click(object sender, EventArgs e)
        {
            using (var lagerhinzufuegen = new LagerHinzufuegen())
            {
                lagerhinzufuegen.Besitzer = this;
                lagerhinzufuegen.Owner = this;
                lagerhinzufuegen.ShowDialog();
            }
        }

        private void LagerEntfernen_Click(object sender, EventArgs e)
        {
            using (var lagerentfernen = new LagerEntfernen())
            {
                lagerentfernen.Besitzer = this;
                lagerentfernen.Owner = this;
                lagerentfernen.ShowDialog();
            }
        }

        private void ForceCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateForm();
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
                regalaendern.Besitzer = this;
                regalaendern.Owner = this;
                regalaendern.ShowDialog();
            }
        }
    }
}