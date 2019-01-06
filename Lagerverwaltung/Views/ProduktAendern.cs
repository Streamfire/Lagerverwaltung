using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Lagerverwaltung.Views
{
    public partial class ProduktAendern : Form
    {
        private Dictionary<long, Model.ArtikeltypModel> _artikeltypDict;

        private BindingSource source = new BindingSource();

        public static string produkt_id;
        public static string name;
        public static string zeichnungsnummer;
        public static string gewicht;
        public static string preis;
        public static string hoehe;
        public static string breite;
        public static string laenge;
        public static string artikeltyp_id;

        public ProduktAendern()
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

            artikeltypBox.SelectedValue = Convert.ToInt64(artikeltyp_id);

            tb_Name.Text = name;
            tb_Zeichnungsnummer.Text = zeichnungsnummer;
            tb_Gewicht.Text = gewicht;
            tb_Preis.Text = preis;
            tb_Hoehe.Text = hoehe;
            tb_Breite.Text = breite;
            tb_Laenge.Text = laenge;
        }

        private void ButtonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonProduktAendern_Click(object sender, EventArgs e)
        {
            if (Controller.ProduktHinzufuegenController.ValidateData(tb_Name.Text, tb_Zeichnungsnummer.Text, tb_Gewicht.Text, tb_Preis.Text, tb_Hoehe.Text, tb_Breite.Text, tb_Laenge.Text))
            
            {
                DB.SqlStatements.UpdateProdukt(Convert.ToInt64(produkt_id), tb_Name.Text, Convert.ToSingle(tb_Gewicht.Text), Convert.ToSingle(tb_Preis.Text), tb_Zeichnungsnummer.Text, Convert.ToInt64(artikeltypBox.SelectedValue), Convert.ToSingle(tb_Hoehe.Text), Convert.ToSingle(tb_Breite.Text), Convert.ToSingle(tb_Laenge.Text));

                ((Produktliste) Owner).UpdateForm();

                Close();
            }

            //Validierung nicht erfolgreich
            else
            {

            }
        }
    }
}
