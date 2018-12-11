using System;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class PaketHinzufuegen : Form
    {
        public PaketHinzufuegen()
        {
            InitializeComponent();
        }
        public static Produktliste Produktliste { get; set; }

        private void ButtonProduktAuswaehlen_Click(object sender, EventArgs e)
        {
            if (Produktliste != null)
            {
                Produktliste.ShowDialog(this);

            }
            else
            {
                Produktliste = new Produktliste();
				Produktliste.FormClosed += OnClose;
                Produktliste.ShowDialog();
            }
        }

		private void OnClose(object sender, FormClosedEventArgs e)
		{
			if(Produktliste.GetSelected() != string.Empty)
			labelProduktAusgewählt.Text = Produktliste.GetSelected();
		}

		private void ButtonAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonPaketHinzufuegen_Click(object sender, EventArgs e)
        {
           if(Controller.PaketHinzufuegenController.ValidateData(textBoxPaketbezeichnung.Text, textBoxAnschaffungsgrund.Text, dateTimePickerHaltbarkeit.Value, textBoxHoehe.Text, textBoxBreite.Text, textBoxLaenge.Text))
            //Validierung erfolgreich
            {
				//TODO:Paket der Paketliste hinzufügen
				var a = (ushort)Views.Dashboard.Verwaltung.getLastFocusedPanel().Tag;

				DB.PaketSQL.ErstellePaket(textBoxPaketbezeichnung.Text,a,Model.Produkt.GetProdukt(labelProduktAusgewählt.Text).ProduktID, Convert.ToInt32(AnzahlBox.Text), dateTimePickerHaltbarkeit.Value, textBoxAnschaffungsgrund.Text, Convert.ToInt32(textBoxHoehe.Text), Convert.ToInt32(textBoxBreite.Text), Convert.ToInt32(textBoxLaenge.Text));
                Close();
            }

            //Validierung nicht erfolgreich
            else
            {

            }
        }
    }
    
}