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
                Produktliste.ShowDialog();
            }
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


                Close();
            }

            //Validierung nicht erfolgreich
            else
            {

            }
        }
    }
    
}