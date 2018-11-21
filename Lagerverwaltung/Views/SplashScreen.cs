using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void Laden()
        {
            try
            {
                DB.HistorieSQL.HoleHistorie();
                DB.ArtikeltypSQL.HoleAlleArtikeltyp();
                DB.LagertypSQL.HoleAlleLagertyp();
                DB.UserSQL.HoleAlleUser();
                DB.RollenSQL.HoleAlleRollen();
                DB.LagerSQL.HoleAlleLager();
                DB.RegalSQL.HoleAlleRegale();
                DB.RegalfachSQL.HoleAlleRegalfach();
                DB.PaketSQL.HoleAllePakete();
                DB.ProduktSQL.HoleAlleProdukte();
                Thread.Sleep(1000);
                this.Invoke((MethodInvoker)delegate{this.Close();});
            }
            catch (System.Exception)
            {
                MessageBox.Show("Bitte vorher die PostgreSQL Datenbank starten!", "Keine Verbindung!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void SplashScreen_Shown(object sender, System.EventArgs e)
        {
            Task f = Task.Factory.StartNew(()=> Laden());
        }
    }
}