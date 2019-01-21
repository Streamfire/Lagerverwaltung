using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Lagerverwaltung.Views
{
    public partial class ProduktAendern : MetroFramework.Forms.MetroForm
    {
        private Dictionary<long, Model.ArtikeltypModel> _artikeltypDict;
        public Form Besitzer { get; set; }

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
            if (String.IsNullOrWhiteSpace(tb_Name.Text) || tb_Name.Text.Length > 25)
            {
                MetroFramework.MetroMessageBox.Show(this, "Produktname überschreitet die zulässige Länge von 25 Zeichen!", "Fehler beim Hinzufügen des Produkts", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    DB.SqlStatements.UpdateProdukt(Convert.ToInt64(produkt_id), tb_Name.Text, Convert.ToSingle(tb_Gewicht.Text), Convert.ToSingle(tb_Preis.Text), tb_Zeichnungsnummer.Text, Convert.ToInt64(artikeltypBox.SelectedValue), Convert.ToSingle(tb_Hoehe.Text), Convert.ToSingle(tb_Breite.Text), Convert.ToSingle(tb_Laenge.Text));

                    ((Produktliste)Besitzer).UpdateForm();

                    Close();
                }
                catch (FormatException)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Falsches Eingabeformat! Bitte geben sie bei Gewicht, Preis, Höhe, Breite und Länge nur Ziffern ein!", "Fehler beim Hinzufügen des Produkts", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (OverflowException)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Eingabe zu großer Zahl! Bitte geben sie bei Gewicht, Preis, Höhe, Breite und Länge nur Zahlen bis 340282300000000000000000000000000000000 ein!", "Fehler beim Hinzufügen des Produkts", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
