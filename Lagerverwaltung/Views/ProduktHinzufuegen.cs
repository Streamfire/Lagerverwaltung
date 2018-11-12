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

        public ProduktHinzufuegen()
        {
            InitializeComponent();
            artikeltypBox.ValueMember = "artikeltyp_id";
            artikeltypBox.DisplayMember = "name";

            _artikeltypListe = new List<Core.Artikeltyp>
            {
                //TEST
                new Core.Artikeltyp(0, "bla", new DateTime(), new DateTime()),
                new Core.Artikeltyp(1, "blubb", new DateTime(), new DateTime()),
                new Core.Artikeltyp(2, "blablubb", new DateTime(), new DateTime()),
                new Core.Artikeltyp(3, "bliblubbbla", new DateTime(), new DateTime())
            };
            //TEST

            //TODO:Artikeltypen aus Datenbank laden


            //in ComboBox eintragen (eventuell auch ohne Zwischengespeicherte Liste)
            foreach (Core.Artikeltyp artikeltyp in _artikeltypListe)
            {
                artikeltypBox.Items.Add(artikeltyp);
            }

            artikeltypBox.SelectedIndex = 0;
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


                Close();
            }

            //Validierung nicht erfolgreich
            else
            {

            }
        }
    }
}
