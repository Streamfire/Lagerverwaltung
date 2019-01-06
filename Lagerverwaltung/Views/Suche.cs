using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
	public partial class Suche : Form
	{
        private ReadOnlyDictionary<ulong, Core.Suche> readonly_dict;
       
        private List<Core.Suche> _result = new List<Core.Suche>();

        private BindingSource source = new BindingSource();

        Form produktlisteSuche = null;

        public Suche()
		{
            DB.SucheSQL.HoleSuchergebnisse();

            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            typeof(DataGridView).InvokeMember(
            "DoubleBuffered",
            BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
            null,
            dataGridView1,
            new object[] { true });

            readonly_dict = Core.Suche.HoleSuchergebnisse;

            dataGridView1.ClearSelection();

            DB.SqlStatements.DatabaseChanged += DataChanged;

            UpdateDataGridView();
        }
        private void UpdateDataGridView(List<Model.Historie> list = null)
        {
            if (list == null)
            {
                source.DataSource = readonly_dict.Values;
            }
            else
            {
                source.DataSource = list;
            }
            dataGridView1.DataSource = source;
        }

        private void DataChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        /// <summary>
        /// Wenn das Fenster geschlossen wird wird die Referenz im Dashboard auf null gesetzt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SucheFormClosing(object sender, FormClosingEventArgs e)
		{
            Dispose();
            Core.Suche.ClearDictionary();
		}

        private void ButtonAbbrechen_Click(object sender, System.EventArgs e)
        {
            Dispose();
            Core.Suche.ClearDictionary();
            Close();
            //Hide();
        }

        private void ButtonSuchen_Click(object sender, System.EventArgs e)
        {
            // Protokolliert genau welche Textboxen geändert wurden
            bool[] changed = new bool[26];
            // Zählt die Anzahl der geänderten Textboxen
            int change = 0;
            // Hält fest, ob es Fehler gab
            bool error = false;

            DateTime tempDate;

            Core.Suchkriterien tmp = new Core.Suchkriterien();

            /* 
             * Try um alle Abfragen der Textboxen, anstatt nur um die kritischen Abfragen, 
             * damit verhindert wird, dass trotzdem gesucht wird, 
             * auch wenn die Textbox dann geleert wird und ohne diese die Suchabfrage durchgeführt wird, 
             * weil das warscheinlich nur zur Verwirrung des Benutzers führt 
             */

            if (!String.IsNullOrWhiteSpace(textLagerName.Text))
            {
                tmp.LagerName = textLagerName.Text;
                changed[0] = true;
                change++;
            }

            if (!String.IsNullOrWhiteSpace(textRegalname.Text))
            {
                tmp.RegalName = textRegalname.Text;
                changed[1] = true;
                change++;
            }


            if (!String.IsNullOrWhiteSpace(textRegalfachname.Text))
            {
                tmp.RegalfachName = textRegalfachname.Text;
                changed[2] = true;
                change++;
            }


            if (!String.IsNullOrWhiteSpace(textProduktname.Text))
            {
                tmp.ProduktName = textProduktname.Text;
                changed[3] = true;
                change++;
            }


            try
            {
                if (!String.IsNullOrWhiteSpace(textProduktID.Text))
                {
                    //tmp.ProduktID = Convert.ToUInt32(textProduktID.Text);
                    tmp.ProduktID = Convert.ToInt64(textProduktID.Text);
                    textProduktID.BackColor = Color.White;
                    changed[4] = true;
                    change++;
                }
            }
            catch (OverflowException)
            {
                textProduktID.BackColor = Color.Red;
                MessageBox.Show("Eingabe zu großer Zahl bei \"Produkt ID\". Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            catch (FormatException)
            {
                textProduktID.BackColor = Color.Red;
                MessageBox.Show("Eingabe bei \"Produkt ID\" hat falsches Format. Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }


            if (!String.IsNullOrWhiteSpace(textZeichnungsnummer.Text))
            {
                tmp.ProduktZeichnungsnummer = textZeichnungsnummer.Text;
                changed[5] = true;
                change++;
            }


            if (!String.IsNullOrWhiteSpace(textPaketname.Text))
            {
                tmp.PaketName = textPaketname.Text;
                changed[6] = true;
                change++;
            }


            if (!String.IsNullOrWhiteSpace(textAnschaffungsgrund.Text))
            {
                tmp.PaketAnschaffungsgrund = textAnschaffungsgrund.Text;
                changed[7] = true;
                change++;
            }


            try
            {
                if (!String.IsNullOrWhiteSpace(textGewichtVon.Text))
                {
                    tmp.ProduktGewicht = Convert.ToSingle(textGewichtVon.Text);
                    textGewichtVon.BackColor = Color.White;
                    changed[8] = true;
                    change++;
                }
            }
            catch (OverflowException)
            {
                textGewichtVon.BackColor = Color.Red;
                MessageBox.Show("Eingabe zu großer Zahl bei \"Gewicht von\". Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            catch (FormatException)
            {
                textGewichtVon.BackColor = Color.Red;
                MessageBox.Show("Eingabe bei \"Gewicht von\" hat falsches Format. Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }



            try
            {
                if (!String.IsNullOrWhiteSpace(textGewichtBis.Text))
                {
                    tmp.ProduktGewicht2 = Convert.ToSingle(textGewichtBis.Text);
                    textGewichtBis.BackColor = Color.White;
                    changed[9] = true;
                    change++;
                }
            }
            catch (OverflowException)
            {
                textGewichtBis.BackColor = Color.Red;
                MessageBox.Show("Eingabe zu großer Zahl bei \"Gewicht bis\". Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            catch (FormatException)
            {
                textGewichtBis.BackColor = Color.Red;
                MessageBox.Show("Eingabe bei \"Gewicht bis\" hat falsches Format. Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }


            try
            {
                if (!String.IsNullOrWhiteSpace(textPreisVon.Text))
                {
                    tmp.ProduktPreis = Convert.ToSingle(textPreisVon.Text);
                    textPreisVon.BackColor = Color.White;
                    changed[10] = true;
                    change++;
                }
            }
            catch (OverflowException)
            {
                textPreisVon.BackColor = Color.Red;
                MessageBox.Show("Eingabe zu großer Zahl bei \"Preis von\". Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            catch (FormatException)
            {
                textPreisVon.BackColor = Color.Red;
                MessageBox.Show("Eingabe bei \"Preis von\" hat falsches Format. Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }


            try
            {
                if (!String.IsNullOrWhiteSpace(textPreisBis.Text))
                {
                    tmp.ProduktPreis2 = Convert.ToSingle(textPreisBis.Text);
                    textPreisBis.BackColor = Color.White;
                    changed[11] = true;
                    change++;
                }
            }
            catch (OverflowException)
            {
                textPreisBis.BackColor = Color.Red;
                MessageBox.Show("Eingabe zu großer Zahl bei \"Preis bis\". Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            catch (FormatException)
            {
                textPreisBis.BackColor = Color.Red;
                MessageBox.Show("Eingabe bei \"Preis bis\" hat falsches Format. Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }


            try
            {
                if (!String.IsNullOrWhiteSpace(textErstelltVon.Text))
                {
                    if (textErstelltVon.Text.Length != 10) throw new FormatException();
                    else if (textErstelltVon.Text[2] != '.' || textErstelltVon.Text[5] != '.') throw new FormatException();
                    else textErstelltVon.BackColor = Color.White;

                    tmp.ProduktErstelltAm = textErstelltVon.Text;
                    changed[12] = true;
                    change++;
                }
            }
            catch (FormatException)
            {
                textErstelltVon.BackColor = Color.Red;
                MessageBox.Show("Falsches Datumsformat bei \"Erstellt von\". Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }


            try
            {
                if (!String.IsNullOrWhiteSpace(textErstelltBis.Text))
                {
                    if (textErstelltBis.Text.Length != 10) throw new FormatException();
                    else if (textErstelltBis.Text[2] != '.' || textErstelltBis.Text[5] != '.') throw new FormatException();
                    else textErstelltBis.BackColor = Color.White;

                    //tmp.ProduktErstelltAm2 = textErstelltBis.Text;

                    DateTime.TryParseExact(textErstelltBis.Text, "dd.MM.yyyy", null, DateTimeStyles.None, out tempDate);
                    tempDate = tempDate.AddDays(1);
                    tmp.ProduktErstelltAm2 = tempDate.ToString("dd.MM.yyyy");

                    changed[13] = true;
                    change++;
                }
            }
            catch (FormatException)
            {
                textErstelltBis.BackColor = Color.Red;
                MessageBox.Show("Falsches Datumsformat bei \"Erstellt bis\". Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }


            try
            {
                if (!String.IsNullOrWhiteSpace(textZuletztGeaendertVon.Text))
                {
                    if (textZuletztGeaendertVon.Text.Length != 10) throw new FormatException();
                    else if (textZuletztGeaendertVon.Text[2] != '.' || textZuletztGeaendertVon.Text[5] != '.') throw new FormatException();
                    else textZuletztGeaendertVon.BackColor = Color.White;

                    tmp.ProduktGeaendertAm = textZuletztGeaendertVon.Text;
                    changed[14] = true;
                    change++;
                }
            }
            catch (FormatException)
            {
                textZuletztGeaendertVon.BackColor = Color.Red;
                MessageBox.Show("Falsches Datumsformat bei \"Zuletzt geändert von\". Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }


            try
            {
                if (!String.IsNullOrWhiteSpace(textZuletztGeaendertBis.Text))
                {
                    if (textZuletztGeaendertBis.Text.Length != 10) throw new FormatException();
                    else if (textZuletztGeaendertBis.Text[2] != '.' || textZuletztGeaendertBis.Text[5] != '.') throw new FormatException();
                    else textZuletztGeaendertBis.BackColor = Color.White;

                    //tmp.ProduktGeaendertAm2 = textZuletztGeaendertBis.Text;

                    DateTime.TryParseExact(textZuletztGeaendertBis.Text, "dd.MM.yyyy", null, DateTimeStyles.None, out tempDate);
                    tempDate = tempDate.AddDays(1);
                    tmp.ProduktGeaendertAm2 = tempDate.ToString("dd.MM.yyyy");

                    changed[15] = true;
                    change++;
                }
            }
            catch (FormatException)
            {
                textZuletztGeaendertBis.BackColor = Color.Red;
                MessageBox.Show("Falsches Datumsformat bei \"Zuletzt geändert bis\". Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }


            try
            {
                if (!String.IsNullOrWhiteSpace(textMengeVon.Text))
                {
                    tmp.PaketMenge = Convert.ToUInt16(textMengeVon.Text);
                    textMengeVon.BackColor = Color.White;
                    changed[16] = true;
                    change++;
                }
            }
            catch (OverflowException)
            {
                textMengeVon.BackColor = Color.Red;
                MessageBox.Show("Eingabe zu großer Zahl bei \"Menge von\". Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            catch (FormatException)
            {
                textMengeVon.BackColor = Color.Red;
                MessageBox.Show("Eingabe bei \"Menge von\" hat falsches Format. Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            try
            {
                if (!String.IsNullOrWhiteSpace(textMengeBis.Text))
                {
                    tmp.PaketMenge2 = Convert.ToUInt16(textMengeBis.Text);
                    textMengeBis.BackColor = Color.White;
                    changed[17] = true;
                    change++;
                }
            }
            catch (OverflowException)
            {
                textMengeBis.BackColor = Color.Red;
                MessageBox.Show("Eingabe zu großer Zahl bei \"Menge bis\". Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            catch (FormatException)
            {
                textMengeBis.BackColor = Color.Red;
                MessageBox.Show("Eingabe bei \"Menge bis\" hat falsches Format. Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }


            try
            {
                if (!String.IsNullOrWhiteSpace(textHaltbarkeitVon.Text))
                {
                    if (textHaltbarkeitVon.Text.Length != 10) throw new FormatException();
                    else if (textHaltbarkeitVon.Text[2] != '.' || textHaltbarkeitVon.Text[5] != '.') throw new FormatException();
                    else textHaltbarkeitVon.BackColor = Color.White;

                    tmp.PaketHaltbarkeit = textHaltbarkeitVon.Text;
                    changed[18] = true;
                    change++;
                }
            }
            catch (FormatException)
            {
                textHaltbarkeitVon.BackColor = Color.Red;
                MessageBox.Show("Falsches Datumsformat bei \"Haltbarkeit von\". Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }


            try
            {
                if (!String.IsNullOrWhiteSpace(textHaltbarkeitBis.Text))
                {
                    if (textHaltbarkeitBis.Text.Length != 10) throw new FormatException();
                    else if (textHaltbarkeitBis.Text[2] != '.' || textHaltbarkeitBis.Text[5] != '.') throw new FormatException();
                    else textHaltbarkeitBis.BackColor = Color.White;

                    //tmp.PaketHaltbarkeit2 = textHaltbarkeitBis.Text;

                    DateTime.TryParseExact(textHaltbarkeitBis.Text, "dd.MM.yyyy", null, DateTimeStyles.None, out tempDate);
                    tempDate = tempDate.AddDays(1);
                    tmp.PaketHaltbarkeit2 = tempDate.ToString("dd.MM.yyyy");

                    changed[19] = true;
                    change++;
                }
            }
            catch (FormatException)
            {
                textHaltbarkeitBis.BackColor = Color.Red;
                MessageBox.Show("Falsches Datumsformat bei \"Haltbarkeit bis\". Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }


            try
            {
                if (!String.IsNullOrWhiteSpace(textHoeheVon.Text))
                {
                    tmp.Hoehe = Convert.ToSingle(textHoeheVon.Text);
                    textHoeheVon.BackColor = Color.White;
                    changed[20] = true;
                    change++;
                }
            }
            catch (OverflowException)
            {
                textHoeheVon.BackColor = Color.Red;
                MessageBox.Show("Eingabe zu großer Zahl bei \"Höhe von\". Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            catch (FormatException)
            {
                textHoeheVon.BackColor = Color.Red;
                MessageBox.Show("Eingabe bei \"Höhe von\" hat falsches Format. Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            try
            {
                if (!String.IsNullOrWhiteSpace(textHoeheBis.Text))
                {
                    tmp.Hoehe2 = Convert.ToSingle(textHoeheBis.Text);
                    textHoeheBis.BackColor = Color.White;
                    changed[21] = true;
                    change++;
                }
            }
            catch (OverflowException)
            {
                textHoeheBis.BackColor = Color.Red;
                MessageBox.Show("Eingabe zu großer Zahl bei \"Höhe bis\". Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            catch (FormatException)
            {
                textHoeheBis.BackColor = Color.Red;
                MessageBox.Show("Eingabe bei \"Höhe bis\" hat falsches Format. Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }


            try
            {
                if (!String.IsNullOrWhiteSpace(textLaengeVon.Text))
                {
                    tmp.Laenge = Convert.ToSingle(textLaengeVon.Text);
                    textLaengeVon.BackColor = Color.White;
                    changed[22] = true;
                    change++;
                }
            }
            catch (OverflowException)
            {
                textLaengeVon.BackColor = Color.Red;
                MessageBox.Show("Eingabe zu großer Zahl bei \"Länge von\". Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            catch (FormatException)
            {
                textLaengeVon.BackColor = Color.Red;
                MessageBox.Show("Eingabe hat \"Länge von\" falsches Format. Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }


            try
            {
                if (!String.IsNullOrWhiteSpace(textLaengeBis.Text))
                {
                    tmp.Laenge2 = Convert.ToSingle(textLaengeBis.Text);
                    textLaengeBis.BackColor = Color.White;
                    changed[23] = true;
                    change++;
                }
            }
            catch (OverflowException)
            {
                textLaengeBis.BackColor = Color.Red;
                MessageBox.Show("Eingabe zu großer Zahl bei \"Länge bis\". Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            catch (FormatException)
            {
                textLaengeBis.BackColor = Color.Red;
                MessageBox.Show("Eingabe bei \"Länge bis\" hat falsches Format. Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }


            try
            {
                if (!String.IsNullOrWhiteSpace(textBreiteVon.Text))
                {
                    tmp.Breite = Convert.ToSingle(textBreiteVon.Text);
                    textBreiteVon.BackColor = Color.White;
                    changed[24] = true;
                    change++;
                }
            }
            catch (OverflowException)
            {
                textBreiteVon.BackColor = Color.Red;
                MessageBox.Show("Eingabe zu großer Zahl bei \"Breite von\". Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            catch (FormatException)
            {
                textBreiteVon.BackColor = Color.Red;
                MessageBox.Show("Eingabe bei \"Breite von\" hat falsches Format. Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }


            try
            {
                if (!String.IsNullOrWhiteSpace(textBreiteBis.Text))
                {
                    tmp.Breite2 = Convert.ToSingle(textBreiteBis.Text);
                    textBreiteBis.BackColor = Color.White;
                    changed[25] = true;
                    change++;
                }
            }
            catch (OverflowException)
            {
                textBreiteBis.BackColor = Color.Red;
                MessageBox.Show("Eingabe zu großer Zahl bei \"Breite bis\". Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            catch (FormatException)
            {
                textBreiteBis.BackColor = Color.Red;
                MessageBox.Show("Eingabe bei \"Breite bis\" hat fálsches Format. Suchanfrage wird ignoriert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            if (error == true) return;

            if (change > 0)
            {
                Core.Suche.ClearDictionary();
                DB.SucheSQL.HoleSuchergebnisse( tmp.LagerName, tmp.RegalName, tmp.RegalfachName, tmp.ProduktName, tmp.ProduktID, tmp.ProduktZeichnungsnummer, tmp.PaketName, tmp.PaketAnschaffungsgrund, tmp.ProduktGewicht, tmp.ProduktGewicht2,
                                                tmp.ProduktPreis, tmp.ProduktPreis2, tmp.ProduktErstelltAm, tmp.ProduktErstelltAm2, tmp.ProduktGeaendertAm, tmp.ProduktGeaendertAm2, tmp.PaketMenge, tmp.PaketMenge2            ,
                                                tmp.PaketHaltbarkeit, tmp.PaketHaltbarkeit2, tmp.Hoehe, tmp.Hoehe2, tmp.Laenge, tmp.Laenge2, tmp.Breite, tmp.Breite2, changed, change                                           );
      
                readonly_dict = Core.Suche.HoleSuchergebnisse;

                UpdateDataGridView();
            }
            else
            {
                Core.Suche.ClearDictionary();

                DB.SucheSQL.HoleSuchergebnisse();

                readonly_dict = Core.Suche.HoleSuchergebnisse;

                UpdateDataGridView();
            }
        }

        private void buttonZurücksetzen_Click(object sender, EventArgs e)
        {
            textLagerName.Text = string.Empty;
            textLagerName.BackColor = Color.White;
            textRegalname.Text = string.Empty;
            textRegalname.BackColor = Color.White;
            textRegalfachname.Text = string.Empty;
            textRegalfachname.BackColor = Color.White;
            textProduktname.Text = string.Empty;
            textProduktname.BackColor = Color.White;
            textProduktID.Text = string.Empty;
            textProduktID.BackColor = Color.White;
            textZeichnungsnummer.Text = string.Empty;
            textZeichnungsnummer.BackColor = Color.White;
            textPaketname.Text = string.Empty;
            textPaketname.BackColor = Color.White;
            textAnschaffungsgrund.Text = string.Empty;
            textAnschaffungsgrund.BackColor = Color.White;
            textGewichtVon.Text = string.Empty;
            textGewichtVon.BackColor = Color.White;
            textGewichtBis.Text = string.Empty;
            textGewichtBis.BackColor = Color.White;
            textPreisVon.Text = string.Empty;
            textPreisVon.BackColor = Color.White;
            textPreisBis.Text = string.Empty;
            textPreisBis.BackColor = Color.White;
            textPreisVon.Text = string.Empty;
            textPreisVon.BackColor = Color.White;
            textErstelltVon.Text = string.Empty;
            textErstelltVon.BackColor = Color.White;
            textErstelltBis.Text = string.Empty;
            textErstelltBis.BackColor = Color.White;
            textZuletztGeaendertVon.Text = string.Empty;
            textZuletztGeaendertVon.BackColor = Color.White;
            textZuletztGeaendertBis.Text = string.Empty;
            textZuletztGeaendertBis.BackColor = Color.White;
            textMengeVon.Text = string.Empty;
            textMengeVon.BackColor = Color.White;
            textMengeBis.Text = string.Empty;
            textMengeBis.BackColor = Color.White;
            textHaltbarkeitVon.Text = string.Empty;
            textHaltbarkeitVon.BackColor = Color.White;
            textHaltbarkeitBis.Text = string.Empty;
            textHaltbarkeitBis.BackColor = Color.White;
            textHoeheVon.Text = string.Empty;
            textHoeheVon.BackColor = Color.White;
            textHoeheBis.Text = string.Empty;
            textHoeheBis.BackColor = Color.White;
            textLaengeVon.Text = string.Empty;
            textLaengeVon.BackColor = Color.White;
            textLaengeBis.Text = string.Empty;
            textLaengeBis.BackColor = Color.White;
            textBreiteVon.Text = string.Empty;
            textBreiteVon.BackColor = Color.White;
            textBreiteBis.Text = string.Empty;
            textBreiteBis.BackColor = Color.White;

            Core.Suche.ClearDictionary();

            DB.SucheSQL.HoleSuchergebnisse();

            readonly_dict = Core.Suche.HoleSuchergebnisse;

            UpdateDataGridView();
        }

        private void checkKompakt_CheckedChanged(object sender, EventArgs e)
        {
            if (checkKompakt.Checked == true)
            {
                this.Size = new Size(1270, 450);
            }
            else
            {
                this.Size = new Size(1270, 840);
            }
        }

        private void buttonProduktliste_Click(object sender, EventArgs e)
        {
            produktlisteSuche = new ProduktlisteSuche();
            produktlisteSuche.Show();
        }
    }
}
