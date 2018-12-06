using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
	public partial class Suche : Form
	{
        private ReadOnlyDictionary<ulong, Model.Suche> readonly_dict;
       
        private List<Model.Suche> _result = new List<Model.Suche>();

        private BindingSource source = new BindingSource();

        public Suche()
		{
			InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;

            readonly_dict = Model.Suche.HoleSuchergebnisse;

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

        /// <summary>
        /// Wenn das Fenster geschlossen wird wird die Referenz im Dashboard auf null gesetzt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SucheFormClosing(object sender, FormClosingEventArgs e)
		{
			Dashboard.Suche = null;
		}

        private void buttonAbbrechen_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }

        private void buttonSuchen_Click(object sender, System.EventArgs e)
        {
            bool[] changed = new bool[25];
            int change = 0;

            Model.Suchkriterien tmp = new Model.Suchkriterien();

            try
            {
                if (!String.IsNullOrWhiteSpace(textRegalname.Text))
                {
                    tmp.RegalName = textRegalname.Text;
                    changed[0] = true;
                    change++;
                }


                if (!String.IsNullOrWhiteSpace(textRegalfachname.Text))
                {
                    tmp.RegalfachName = textRegalfachname.Text;
                    changed[1] = true;
                    change++;
                }


                if (!String.IsNullOrWhiteSpace(textProduktname.Text))
                {
                    tmp.ProduktName = textProduktname.Text;
                    changed[2] = true;
                    change++;
                }


                if (!String.IsNullOrWhiteSpace(textProduktID.Text))
                {
                    tmp.ProduktID = Convert.ToUInt32(textProduktID.Text);
                    changed[3] = true;
                    change++;
                }


                if (!String.IsNullOrWhiteSpace(textZeichnungsnummer.Text))
                {
                    tmp.ProduktZeichnungsnummer = textZeichnungsnummer.Text;
                    changed[4] = true;
                    change++;
                }


                if (!String.IsNullOrWhiteSpace(textPaketname.Text))
                {
                    tmp.PaketName = textPaketname.Text;
                    changed[5] = true;
                    change++;
                }


                if (!String.IsNullOrWhiteSpace(textAnschaffungsgrund.Text))
                {
                    tmp.PaketAnschaffungsgrund = textAnschaffungsgrund.Text;
                    changed[6] = true;
                    change++;
                }

                if (!String.IsNullOrWhiteSpace(textGewichtVon.Text))
                {
                    tmp.ProduktGewicht = Convert.ToSingle(textGewichtVon.Text);
                    changed[7] = true;
                    change++;
                }


                if (!String.IsNullOrWhiteSpace(textGewichtBis.Text))
                {
                    tmp.ProduktGewicht2 = Convert.ToSingle(textGewichtBis.Text);
                    changed[8] = true;
                    change++;
                }


                if (!String.IsNullOrWhiteSpace(textPreisVon.Text))
                {
                    tmp.ProduktPreis = Convert.ToSingle(textPreisVon.Text);
                    changed[9] = true;
                    change++;
                }


                if (!String.IsNullOrWhiteSpace(textPreisBis.Text))
                {
                    tmp.ProduktPreis2 = Convert.ToSingle(textPreisBis.Text);
                    changed[10] = true;
                    change++;
                }


                if (!String.IsNullOrWhiteSpace(textErstelltVon.Text))
                {
                    tmp.ProduktErstelltAm = textErstelltVon.Text;
                    changed[11] = true;
                    change++;
                }


                if (!String.IsNullOrWhiteSpace(textErstelltBis.Text))
                {
                    tmp.ProduktErstelltAm2 = textErstelltBis.Text;
                    changed[12] = true;
                    change++;
                }



                if (!String.IsNullOrWhiteSpace(textZuletztGeaendertVon.Text))
                {
                    tmp.ProduktGeaendertAm = textZuletztGeaendertVon.Text;
                    changed[13] = true;
                    change++;
                }


                if (!String.IsNullOrWhiteSpace(textZuletztGeaendertBis.Text))
                {
                    tmp.ProduktGeaendertAm2 = textZuletztGeaendertBis.Text;
                    changed[14] = true;
                    change++;
                }


                if (!String.IsNullOrWhiteSpace(textMengeVon.Text))
                {
                    tmp.PaketMenge = Convert.ToUInt16(textMengeVon.Text);
                    changed[15] = true;
                    change++;
                }


                if (!String.IsNullOrWhiteSpace(textMengeBis.Text))
                {
                    tmp.PaketMenge2 = Convert.ToUInt16(textMengeBis.Text);
                    changed[16] = true;
                    change++;
                }


                if (!String.IsNullOrWhiteSpace(textHaltbarkeitVon.Text))
                {
                    tmp.PaketHaltbarkeit = textHaltbarkeitVon.Text;
                    changed[17] = true;
                    change++;
                }


                if (!String.IsNullOrWhiteSpace(textHaltbarkeitBis.Text))
                {
                    tmp.PaketHaltbarkeit = textHaltbarkeitVon.Text;
                    changed[18] = true;
                    change++;
                }



                if (!String.IsNullOrWhiteSpace(textHoeheVon.Text))
                {
                    tmp.Hoehe = Convert.ToSingle(textHoeheVon.Text);
                    changed[19] = true;
                    change++;
                }



                if (!String.IsNullOrWhiteSpace(textHoeheBis.Text))
                {
                    tmp.Hoehe2 = Convert.ToSingle(textHoeheBis.Text);
                    changed[20] = true;
                    change++;
                }


                if (!String.IsNullOrWhiteSpace(textLaengeVon.Text))
                {
                    tmp.Laenge = Convert.ToSingle(textLaengeVon.Text);
                    changed[21] = true;
                    change++;
                }


                if (!String.IsNullOrWhiteSpace(textLaengeBis.Text))
                {
                    tmp.Laenge2 = Convert.ToSingle(textLaengeBis.Text);
                    changed[22] = true;
                    change++;
                }


                if (!String.IsNullOrWhiteSpace(textBreiteVon.Text))
                {
                    tmp.Breite = Convert.ToSingle(textBreiteVon.Text);
                    changed[23] = true;
                    change++;
                }


                if (!String.IsNullOrWhiteSpace(textBreiteBis.Text))
                {
                    tmp.Breite2 = Convert.ToSingle(textBreiteBis.Text);
                    changed[24] = true;
                    change++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Falsche Eingabe. Bitte überprüfen sie nochmals ihre Eingaben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (change > 0)
            {
                Model.Suche._dict.Clear();
                DB.SucheSQL.HoleSuchergebnisse( tmp.RegalName, tmp.RegalfachName, tmp.ProduktName, tmp.ProduktID, tmp.ProduktZeichnungsnummer, tmp.PaketName, tmp.PaketAnschaffungsgrund, tmp.ProduktGewicht, tmp.ProduktGewicht2,
                                                tmp.ProduktPreis, tmp.ProduktPreis2, tmp.ProduktErstelltAm, tmp.ProduktErstelltAm2, tmp.ProduktGeaendertAm, tmp.ProduktGeaendertAm2, tmp.PaketMenge, tmp.PaketMenge2            ,
                                                tmp.PaketHaltbarkeit, tmp.PaketHaltbarkeit2, tmp.Hoehe, tmp.Hoehe2, tmp.Laenge, tmp.Laenge2, tmp.Breite, tmp.Breite2, changed, change                                           );
      
                readonly_dict = Model.Suche.HoleSuchergebnisse;

                UpdateDataGridView();
            }
            else
            {
                var obj = new object();

                Model.Suche._dict.Clear();

                DB.SucheSQL.HoleSuchergebnisse();

                readonly_dict = Model.Suche.HoleSuchergebnisse;

                UpdateDataGridView();
            }
        }
    }
}
