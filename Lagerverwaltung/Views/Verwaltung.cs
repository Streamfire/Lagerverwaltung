using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
	public partial class Verwaltung : Form
	{
		public Verwaltung()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Wenn das Fenster geschlossen wird wird die Referenz im Dashboard auf null gesetzt.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void VerwaltungFormClosing(object sender, FormClosingEventArgs e)
		{
			Dashboard.Verwaltung = null;
		}

        public static PaketHinzufügen PaketHinzufügen { get => _paketHinzufuegen; set => _paketHinzufuegen = value; }
        public static RegalHinzufügen RegalHinzufügen { get => _regalHinzufuegen; set => _regalHinzufuegen = value; }
        public static RegalAendern_Entfernen RegalAendern_Entfernen { get => _regalAendernEnt; set => _regalAendernEnt = value; }
        public static LagerHinzufuegen LagerHinzufuegen { get => _lagerHinzufuegen; set => _lagerHinzufuegen = value; }
        private static PaketHinzufügen _paketHinzufuegen = null;
        private static RegalHinzufügen _regalHinzufuegen = null;
        private static RegalAendern_Entfernen _regalAendernEnt = null;
        private static LagerHinzufuegen _lagerHinzufuegen = null;
        private void buttonRegalHinzufuegen_Click(object sender, System.EventArgs e)
        {
            if (RegalHinzufügen != null)
            {
                RegalHinzufügen.ShowDialog(this);

            }
            else
            {
                RegalHinzufügen = new RegalHinzufügen();
                RegalHinzufügen.ShowDialog();
            }
        }

        private void buttonLagerHinzufuegen_Click(object sender, System.EventArgs e)
        {
            if (LagerHinzufuegen != null)
            {
                LagerHinzufuegen.ShowDialog(this);

            }
            else
            {
                LagerHinzufuegen = new LagerHinzufuegen();
                LagerHinzufuegen.ShowDialog();
            }
        }

        private void buttonPaketHinzufuegen_Click(object sender, System.EventArgs e)
        {
            if (PaketHinzufügen != null)
            {
                PaketHinzufügen.ShowDialog(this);

            }
            else
            {
                PaketHinzufügen = new PaketHinzufügen();
                PaketHinzufügen.ShowDialog();
            }
        }
        private void buttonRegalEntfernen_Click(object sender, System.EventArgs e)
        {
            if (RegalAendern_Entfernen != null)
            {
                RegalAendern_Entfernen.ShowDialog(this);

            }
            else
            {
                RegalAendern_Entfernen = new RegalAendern_Entfernen();
                RegalAendern_Entfernen.ShowDialog();
            }
        }
        private void buttonZurück_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}
