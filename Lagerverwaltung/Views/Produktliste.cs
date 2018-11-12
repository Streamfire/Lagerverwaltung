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
    public partial class Produktliste : Form
    {
        private List<Core.Produkt> _produktListe;

        public Produktliste()
        {
            InitializeComponent();

            //TODO: Produkte aus DB oder SW-Liste laden
            _produktListe = new List<Core.Produkt>();

            //TEST
            _produktListe.Add(new Core.Produkt(0, "Eimer", "31M32", 40.2f, 40.3f, 450403, 923425, new Core.Artikeltyp(0, "bla", 50, 60), 40, 60, 80));
            _produktListe.Add(new Core.Produkt(1, "Tisch", "T15-CH", 100.23f, 1.01f, 4567, 3425, new Core.Artikeltyp(1, "blubb", 50, 60), 1000, 2000, 500));
            _produktListe.Add(new Core.Produkt(2, "Dildo", "D-1L-D0", 1.15f, 9000, 12345, 54321, new Core.Artikeltyp(0, "bla", 50, 60), 300, 100, 100));
            _produktListe.Add(new Core.Produkt(3, "Thermoskanne voll Mett", "N0-T4-5CH-3N-Mu-Mu", 500, 1500, 1235634, 23515, new Core.Artikeltyp(0, "bla", 50, 60), 500, 500, 500));
            //TEST

            foreach (Core.Produkt produkt in _produktListe)
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
    }
}
