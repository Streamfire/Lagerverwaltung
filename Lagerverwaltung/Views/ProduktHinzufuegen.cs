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
    public partial class ProduktHinzufuegen : Form
    {
        private List<Core.Artikeltyp> _artikeltypListe;
		private Produktliste _parent;

        public ProduktHinzufuegen()
        {
            InitializeComponent();
            artikeltypBox.ValueMember = "artikeltyp_id";
            artikeltypBox.DisplayMember = "name";

            _artikeltypListe = Dashboard.ArtikeltypListe;            
            //TEST

            //TODO:Artikeltypen aus Datenbank laden


            //in ComboBox eintragen (eventuell auch ohne Zwischengespeicherte Liste)
            foreach (Core.Artikeltyp artikeltyp in _artikeltypListe)
            {
                artikeltypBox.Items.Add(artikeltyp);
            }

            artikeltypBox.SelectedIndex = 0;

			_parent = PaketHinzufuegen.Produktliste;

		}

        private void ButtonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonProduktHinzufuegen_Click(object sender, EventArgs e)
        {
            if (Controller.ProduktHinzufuegenController.ValidateData(tb_Name.Text, tb_Zeichnungsnummer.Text, tb_Gewicht.Text, tb_Preis.Text))
            
            //Validierung erfolgreich
            {
                //TODO:Produkt der Produktliste hinzufügen
                Dashboard.ProduktListe.Add(new Core.Produkt(0, tb_Name.Text, tb_Zeichnungsnummer.Text, Convert.ToSingle(tb_Gewicht.Text), Convert.ToSingle(tb_Preis.Text), new DateTime(), new DateTime(), 0,0f,0f,0f));
				_parent.UpdateForm(Dashboard.ProduktListe);
                Close();
            }

            //Validierung nicht erfolgreich
            else
            {

            }
        }
    }
}
