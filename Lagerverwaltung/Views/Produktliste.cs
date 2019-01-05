using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class Produktliste : Form
    {
        //private Dictionary<long, Model.ProduktModel> _dictProdukt;
        private List<Model.ProduktModel> _dictProdukt;

        private BindingSource source = new BindingSource();

        public Produktliste()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            _dictProdukt = DB.SqlStatements.HoleAlleProdukte();

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

            UpdateForm();
			
      
        }
		public void UpdateForm()
        {
            //dataGridView1.DataSource = Model.Produkt.GetProdukts();
            dataGridView1.DataSource = _dictProdukt;

            /*
			listViewProduktliste.Items.Clear();
            var test = Model.Produkt.GetProdukts();

			foreach (Model.Produkt produkt in test)
			{
				dataGridView1.Items.Add(new ListViewItem(new string[] {
					produkt.Name,
					produkt.Gewicht.ToString(),
					produkt.Preis.ToString(),
					produkt.Zeichnungsnummer,
					produkt.ErstelltAm.ToString(),
					produkt.GeaendertAm.ToString() }));
			}
            if(listViewProduktliste.Items.Count>0)
            {
                listViewProduktliste.Items[0].Focused = true;
                listViewProduktliste.Items[0].Selected = true;
            }*/
        }

        private void Schliessen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Produkt_hinzufuegen_Click(object sender, EventArgs e)
        {
            using (var produkthinzufuegen = new ProduktHinzufuegen())
            {
                produkthinzufuegen.ShowDialog();
            }
        }

		/// <summary>
		/// Produkt ausgewählt
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Auswaehlen_Click(object sender, EventArgs e)
		{
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string a = Convert.ToString(selectedRow.Cells["name"].Value);

            PaketHinzufuegen.Auswahl = a;

            //TODO: ProduktID muss in PaketHinzufügen Form übergeben werden
            PaketHinzufuegen.ProduktID = Convert.ToInt64(selectedRow.Cells["produkt_id"].Value);

            Close();
		}

		private void ListViewProduktliste_SelectedIndexChanged(object sender, EventArgs e)
		{
            //throw new NotImplementedException();
		}

        private void Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }

    
}
