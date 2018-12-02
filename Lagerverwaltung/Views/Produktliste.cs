using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class Produktliste : Form
    {
       // private List<Core.Produkt> _produktListe;

        public Produktliste()
        {
            InitializeComponent();


			/*
            //TODO: Produkte aus DB oder SW-Liste laden
            _produktListe = new List<Core.Produkt>
            {
                //TEST
                new Core.Produkt(0, "DeWalt Schrauber", "DT71572-QZ", 0.581f, 11.99f, new DateTime(), new DateTime(), 0, 400, 600, 800),
                new Core.Produkt(1, "Scheppach Dekupiersägeblatt-Set", "6206P", 0.200f, 19.99f, new DateTime(), new DateTime(), 0, 1000, 2000, 500),
                new Core.Produkt(2, "Erbauer T144DP Stichsägeblatt", "7153K", 0.055f, 2.19f, new DateTime(), new DateTime(), 0, 300, 100, 100),
                new Core.Produkt(3, "Ponal SUPER 3 Holzleim", "PN 15S 120", 0.12f, 6.89f, new DateTime(), new DateTime(), 0, 500, 500, 500)
                
            };
            */
			UpdateForm( Dashboard.ProduktListe);
			
      
        }
		public void UpdateForm(List<Model.Produkt> _produktListe)
		{
			listViewProduktliste.Items.Clear();

			foreach (Model.Produkt produkt in _produktListe)
			{
				listViewProduktliste.Items.Add(new ListViewItem(new string[] {
					produkt.Name,
					produkt.Gewicht.ToString(),
					produkt.Preis.ToString(),
					produkt.Zeichnungsnummer,
					produkt.ErstelltAm.ToString(),
					produkt.GeaendertAm.ToString() }));
			}
			listViewProduktliste.Items[0].Focused = true;
			listViewProduktliste.Items[0].Selected = true;
		}

        private void Schliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static ProduktHinzufuegen ProduktHinzufuegen { get; set; }

    private void Produkt_hinzufuegen_Click(object sender, EventArgs e)
        {
            if (ProduktHinzufuegen != null)
            {
                ProduktHinzufuegen.ShowDialog(this);

            }
            else
            {
                ProduktHinzufuegen = new ProduktHinzufuegen();
                ProduktHinzufuegen.ShowDialog();
            }

        }

		/// <summary>
		/// Produkt ausgewählt
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Auswaehlen_Click(object sender, EventArgs e)
		{
			lastSelected = listViewProduktliste.SelectedItems[0].Text;
			this.Close();
		}

		string lastSelected;

		public string GetSelected()
		{
			return lastSelected;
		}
	}

    
}
