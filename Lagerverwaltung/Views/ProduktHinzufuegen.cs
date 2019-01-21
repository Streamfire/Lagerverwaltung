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

            _artikeltypDict = DB.SqlStatements.HoleArtikeltyp();

            artikeltypBox.DataSource = _artikeltypDict.Values.ToArray();
		}

        private void ButtonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Fügt ein Produkt hinzu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonProduktHinzufuegen_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_Name.Text) || tb_Name.Text.Length > 25 )
            {
                MetroFramework.MetroMessageBox.Show(this, "Produktname ist leer oder überschreitet die zulässige Länge von 25 Zeichen!", "Fehler beim Hinzufügen des Produkts", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (String.IsNullOrWhiteSpace(tb_Gewicht.Text) || !Char.IsDigit(tb_Gewicht.Text[0]) || String.IsNullOrWhiteSpace(tb_Preis.Text)     || 
                    !Char.IsDigit(tb_Preis.Text[0]) || String.IsNullOrWhiteSpace(tb_Hoehe.Text) || !Char.IsDigit(tb_Hoehe.Text[0])                  ||
                    String.IsNullOrWhiteSpace(tb_Breite.Text) || !Char.IsDigit(tb_Breite.Text[0]) || String.IsNullOrWhiteSpace(tb_Laenge.Text)      || 
                    !Char.IsDigit(tb_Laenge.Text[0])                                                                                                )
                {
                    MetroFramework.MetroMessageBox.Show(this, "Negative oder keine Werte bei Gewicht, Preis, Höhe, Breite, oder Länge", "Fehler beim Hinzufügen des Produkts", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        DB.SqlStatements.ErstelleProdukt(tb_Name.Text, Convert.ToSingle(tb_Gewicht.Text), Convert.ToSingle(tb_Preis.Text), tb_Zeichnungsnummer.Text, Convert.ToInt64(artikeltypBox.SelectedValue), Convert.ToSingle(tb_Hoehe.Text), Convert.ToSingle(tb_Breite.Text), Convert.ToSingle(tb_Laenge.Text));

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
}
