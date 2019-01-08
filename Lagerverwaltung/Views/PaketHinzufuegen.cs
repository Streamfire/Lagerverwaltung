using System;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    /// <summary>
    /// @Martin hier kommen auch Overflow und FormatExceptions vor, aber ich will hier nichts verändern, damit du den Überblick nicht verlierst. ValidateData schütz davor anscheindend nicht.
    /// </summary>
    public partial class PaketHinzufuegen : MetroFramework.Forms.MetroForm
    {
        public PaketHinzufuegen()
        {
            InitializeComponent();
        }

        public static string Auswahl { get; set; } = "";
        public static long ProduktID { get; set; } = -1;
        public Form Besitzer { get; set; }
        public static Produktliste Produktliste { get; set; } // entfernen und Abhängigkeiten ändern
        public long RegalfachID { get; set; } = -1;

        private void PaketHinzufuegenButton_Click(object sender, EventArgs e)
        {
            if (RegalfachID <= 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Es konnte keine Regalfach-ID gefunden werden!" + RegalfachID, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            if (ProduktID < 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Bitte wählen Sie ein Produkt aus!" + RegalfachID, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Controller.PaketHinzufuegenController.ValidateData(BezeichungTextbox.Text, GrundTextbox.Text, HaltbarkeitDatetime.Value, HoeheTextbox.Text, BreiteTextbox.Text, LaengeTextbox.Text))
            //Validierung erfolgreich
            {

                if (Besitzer.GetType().Equals(typeof(Regaleinsicht)))
                {

                    DB.SqlStatements.ErstellePaket(BezeichungTextbox.Text, RegalfachID, ProduktID, Convert.ToInt16(AnzahlTextbox.Text), HaltbarkeitDatetime.Value, GrundTextbox.Text, Convert.ToInt32(HoeheTextbox.Text), Convert.ToInt32(BreiteTextbox.Text), Convert.ToInt32(LaengeTextbox.Text));
                    Close();
                }
                else if (Besitzer.GetType().Equals(typeof(Verwaltung)))
                {
                    var a = (ushort)Views.Dashboard.Verwaltung.getLastFocusedPanel().Tag;

                    DB.PaketSQL.ErstellePaket(BezeichungTextbox.Text, a, Model.Produkt.GetProdukt(AuswahlLabel.Text).ProduktID, Convert.ToInt32(AnzahlTextbox.Text), HaltbarkeitDatetime.Value, GrundTextbox.Text, Convert.ToInt32(HoeheTextbox.Text), Convert.ToInt32(BreiteTextbox.Text), Convert.ToInt32(LaengeTextbox.Text));
                    Close();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Es konnte kein Hauptfenster gefunden werden. Bitte starten Sie das Programm erneut", "Fehler im Hauptfenster", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Validierung nicht erfolgreich
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Bitte Überprüfen sie das eingegebene Format der Daten", "Fehler beim Hinzufügen des Paketes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AbbrechenButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProduktlisteButton_Click(object sender, EventArgs e)
        {
            using (var produktliste = new Produktliste())
            {
                produktliste.FormClosed += OnClose;
                produktliste.ShowDialog();
            }
        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            if (Auswahl.Length != 0)
            {
                AuswahlLabel.Text = Auswahl;
            }
        }
    }
}