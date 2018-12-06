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

                //DB.SucheSQL.HoleSuchergebnisse();

                DB.ArtikeltypSQL.HoleAlleArtikeltyp();
       
                //DB.LagertypSQL.HoleAlleLagertyp();
          
                DB.UserSQL.HoleAlleUser();
             
                DB.RollenSQL.HoleAlleRollen();
      
                DB.LagerSQL.HoleAlleLager();
      
                DB.RegalSQL.HoleAlleRegale();
          
                DB.RegalfachSQL.HoleAlleRegalfach();
       
                DB.PaketSQL.HoleAllePakete();
            
                DB.ProduktSQL.HoleAlleProdukte();
                this.Invoke((MethodInvoker)delegate { this.DialogResult = DialogResult.OK; this.Close(); });
            }
            catch(System.TypeInitializationException)
            {
                MessageBox.Show("Bitte vorher die PostgreSQL Datenbank starten!", "Keine Verbindung!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message,"Ausnahmebehandlung",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void SplashScreen_Shown(object sender, System.EventArgs e)
        {
            Task f = Task.Factory.StartNew(()=> Laden());
        }
    }
}