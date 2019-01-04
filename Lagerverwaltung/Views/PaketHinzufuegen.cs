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

        public static string Auswahl { get; set; }
        public static long ProduktID { get; set; } = 1;
        public static Produktliste Produktliste { get; set; } // entfernen und Abhängigkeiten ändern
        public long RegalfachID { get; set; } = -1;

        private void ButtonProduktAuswaehlen_Click(object sender, EventArgs e)
        {
            /* Wenn Abhängigkeiten entfernt - bitte das freischalten und das andere darunter entfernen :)
            using (var produktliste = new Produktliste())
            {
                produktliste.FormClosed += OnClose;
                produktliste.ShowDialog();
            }
            */
            
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
            if(Auswahl.Length != 0)
            {
                labelProduktAusgewählt.Text = Auswahl;
            }
		}

		private void ButtonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonPaketHinzufuegen_Click(object sender, EventArgs e)
        {
            if (RegalfachID <= 0)
            {
                MessageBox.Show("Es konnte keine Regalfach-ID gefunden werden!" + RegalfachID, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            if (Controller.PaketHinzufuegenController.ValidateData(textBoxPaketbezeichnung.Text, textBoxAnschaffungsgrund.Text, dateTimePickerHaltbarkeit.Value, textBoxHoehe.Text, textBoxBreite.Text, textBoxLaenge.Text))
            //Validierung erfolgreich
            {

                if (Owner.GetType().Equals(typeof(Regaleinsicht)))
                {

                    DB.SqlStatements.ErstellePaket(textBoxPaketbezeichnung.Text, RegalfachID, ProduktID, Convert.ToInt16(AnzahlBox.Text), dateTimePickerHaltbarkeit.Value, textBoxAnschaffungsgrund.Text, Convert.ToInt32(textBoxHoehe.Text), Convert.ToInt32(textBoxBreite.Text), Convert.ToInt32(textBoxLaenge.Text));

                    MessageBox.Show("RegalfachID: " + RegalfachID, "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else if (Owner.GetType().Equals(typeof(Verwaltung)))
                {
                    var a = (ushort)Views.Dashboard.Verwaltung.getLastFocusedPanel().Tag;

                    DB.PaketSQL.ErstellePaket(textBoxPaketbezeichnung.Text, a, Model.Produkt.GetProdukt(labelProduktAusgewählt.Text).ProduktID, Convert.ToInt32(AnzahlBox.Text), dateTimePickerHaltbarkeit.Value, textBoxAnschaffungsgrund.Text, Convert.ToInt32(textBoxHoehe.Text), Convert.ToInt32(textBoxBreite.Text), Convert.ToInt32(textBoxLaenge.Text));
                    Close();
                }
                else
                {
                    MessageBox.Show("Es konnte kein Hauptfenster gefunden werden. Bitte starten Sie das Programm erneut", "Fehler im Hauptfenster", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Validierung nicht erfolgreich
            else
            {
                MessageBox.Show("Bitte Überprüfen sie das eingegebene Format der Daten", "Fehler beim Hinzufügen des Paketes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
    
}