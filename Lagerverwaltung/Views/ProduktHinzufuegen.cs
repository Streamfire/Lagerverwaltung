using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Lagerverwaltung.Views
{
    public partial class ProduktHinzufuegen : MetroFramework.Forms.MetroForm
    {
        private Dictionary<long, Model.ArtikeltypModel> _artikeltypDict;
        public Form Besitzer { get; set; }

        public ProduktHinzufuegen()
        {
            InitializeComponent();
            artikeltypBox.ValueMember = "artikeltyp_id";
            artikeltypBox.DisplayMember = "name";

            //_artikeltypListe. = DB.SqlStatements.HoleAlleArtikeltypen();

            //Dashboard.ArtikeltypListe;            
            //TEST

            //TODO:Artikeltypen aus Datenbank laden


            //in ComboBox eintragen (eventuell auch ohne Zwischengespeicherte Liste)
            /*
            foreach (Model.ArtikeltypModel artikeltyp in _artikeltypListe)
            {
                artikeltypBox.Items.Add(artikeltyp);
            }*/

            _artikeltypDict = DB.SqlStatements.HoleArtikeltyp();

            artikeltypBox.DataSource = _artikeltypDict.Values.ToArray();


            //artikeltypBox.SelectedIndex = 0;

		}

        private void ButtonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonProduktHinzufuegen_Click(object sender, EventArgs e)
        {
            if (Controller.ProduktHinzufuegenController.ValidateData(tb_Name.Text, tb_Zeichnungsnummer.Text, tb_Gewicht.Text, tb_Preis.Text, tb_Hoehe.Text, tb_Breite.Text, tb_Laenge.Text))
            
            {
                DB.SqlStatements.ErstelleProdukt(tb_Name.Text, Convert.ToSingle(tb_Gewicht.Text), Convert.ToSingle(tb_Preis.Text), tb_Zeichnungsnummer.Text, Convert.ToInt64(artikeltypBox.SelectedValue), Convert.ToSingle(tb_Hoehe.Text), Convert.ToSingle(tb_Breite.Text), Convert.ToSingle(tb_Laenge.Text));

                ((Produktliste) Besitzer).UpdateForm();

                Close();
            }

            //Validierung nicht erfolgreich
            else
            {

            }
        }
    }
}
