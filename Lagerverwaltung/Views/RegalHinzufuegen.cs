using Lagerverwaltung.Model;
using System;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class RegalHinzufügen : Form
    {
        public RegalHinzufügen()
        {
            InitializeComponent();
            comboBoxAuswahlLager.ValueMember = "LagerID";
            comboBoxAuswahlLager.DisplayMember = "Name";

            comboBoxAuswahlLager.DataSource = new BindingSource(Model.Lager.HoleListe.Values, null);

        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void buttonRegalHinzufuegen_Click(object sender, EventArgs e)
		{
			byte zeilen = Convert.ToByte(this.textBoxZeilen.Text);
			byte spalten = Convert.ToByte(this.textBoxSpalten.Text);
            int aktuelleAnzahlFaecher = Regalfach.HoleListe.Values.Count;
            Lager ausgewaehltesLager = (Lager)comboBoxAuswahlLager.SelectedItem;


            Regal n = new Regal((ushort)(Regal.HoleListe.Count + 1), ausgewaehltesLager.LagerID, this.textBoxRegalName.Text,zeilen,spalten, new DateTime(), new DateTime(), 0, 0, 0, 0, 0);

			for (int z = 0; z < zeilen; z++)
			{
				for (int s = 0; s < spalten;  s++)
				{
                    //Falls in der DB die IDs mit 0 beginnen, die + 1 für die Berechnung der IDs entfernen
					n.Regalfachliste.Add(new Regalfach((ushort)((zeilen * z) + s + aktuelleAnzahlFaecher + 1), n.RegalID, "" + z + ";" + s, new DateTime(), new DateTime(), 0, 0, 0, ""));

				}
			}


			

			//Dashboard.LagerListe[Dashboard.Verwaltung.getActiveTabIndex()].Regalliste.Add(n);

			Dashboard.Verwaltung.UpdateForm(Model.Lager.HoleListe);
			this.Close();
		}
	}
}
