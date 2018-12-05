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
            Model.Suche tmp = new Model.Suche();

            if (!String.IsNullOrWhiteSpace(textRegalname.Text))
                tmp.RegalName = textRegalname.Text;

            if (!String.IsNullOrWhiteSpace(textRegalfachname.Text))
                tmp.RegalfachName = textRegalfachname.Text;

            if (!String.IsNullOrWhiteSpace(textProduktname.Text))
                tmp.ProduktName = textProduktname.Text;

            if (!String.IsNullOrWhiteSpace(textProduktID.Text))
                tmp.ProduktID = Convert.ToUInt32(textProduktID.Text);

            if (!String.IsNullOrWhiteSpace(textZeichnungsnummer.Text))
                tmp.ProduktZeichnungsnummer = textZeichnungsnummer.Text;

            if (!String.IsNullOrWhiteSpace(textPaketname.Text))
                tmp.PaketName = textPaketname.Text;

            if (!String.IsNullOrWhiteSpace(textAnschaffungsgrund.Text))
                tmp.PaketAnschaffungsgrund = textAnschaffungsgrund.Text;

            if (!String.IsNullOrWhiteSpace(textGewichtVon.Text))
                tmp.ProduktGewicht = Convert.ToSingle(textGewichtVon.Text);

            if (!String.IsNullOrWhiteSpace(textGewichtBis.Text))
                tmp.ProduktGewicht2 = Convert.ToSingle(textGewichtBis.Text);

            if (!String.IsNullOrWhiteSpace(textPreisVon.Text))
                tmp.ProduktPreis = Convert.ToSingle(textPreisVon.Text);

            if (!String.IsNullOrWhiteSpace(textPreisBis.Text))
                tmp.ProduktPreis2 = Convert.ToSingle(textPreisBis.Text);

            if (!String.IsNullOrWhiteSpace(textErstelltVon.Text))
                tmp.ProduktErstelltAm = DateTime.ParseExact(textErstelltVon.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            if (!String.IsNullOrWhiteSpace(textErstelltBis.Text))
                tmp.ProduktErstelltAm2 = DateTime.ParseExact(textErstelltBis.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            if (!String.IsNullOrWhiteSpace(textZuletztGeaendertVon.Text))
                tmp.ProduktGeaendertAm = DateTime.ParseExact(textZuletztGeaendertVon.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            if (!String.IsNullOrWhiteSpace(textZuletztGeaendertBis.Text))
                tmp.ProduktGeaendertAm2 = DateTime.ParseExact(textZuletztGeaendertBis.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            if (!String.IsNullOrWhiteSpace(textMengeVon.Text))
                tmp.PaketMenge = Convert.ToUInt16(textMengeVon.Text);

            if (!String.IsNullOrWhiteSpace(textMengeBis.Text))
                tmp.PaketMenge2 = Convert.ToUInt16(textMengeBis.Text);

            if (!String.IsNullOrWhiteSpace(textHaltbarkeitVon.Text))
                tmp.PaketHaltbarkeit = DateTime.ParseExact(textHaltbarkeitVon.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            if (!String.IsNullOrWhiteSpace(textHaltbarkeitBis.Text))
                tmp.PaketHaltbarkeit2 = DateTime.ParseExact(textHaltbarkeitBis.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            if (!String.IsNullOrWhiteSpace(textHoeheVon.Text))
                tmp.Hoehe = Convert.ToSingle(textHoeheVon.Text);

            if (!String.IsNullOrWhiteSpace(textHoeheBis.Text))
                tmp.Hoehe2 = Convert.ToSingle(textHoeheBis.Text);

            if (!String.IsNullOrWhiteSpace(textLaengeVon.Text))
                tmp.Laenge = Convert.ToSingle(textLaengeVon.Text);

            if (!String.IsNullOrWhiteSpace(textLaengeBis.Text))
                tmp.Laenge2 = Convert.ToSingle(textLaengeBis.Text);

            if (!String.IsNullOrWhiteSpace(textBreiteVon.Text))
                tmp.Breite = Convert.ToSingle(textBreiteVon.Text);

            if (!String.IsNullOrWhiteSpace(textBreiteBis.Text))
                tmp.Breite2 = Convert.ToSingle(textBreiteBis.Text);


            /*
            DB.SucheSQL.HoleSuchergebnisse();
            readonly_dict = null;
            readonly_dict = Model.Suche.HoleSuchergebnisse;
            */
        }



        //throw new DivideByZeroException();
    }
}
