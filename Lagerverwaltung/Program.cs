using System;
using System.Threading;
using System.Windows.Forms;
using Lagerverwaltung.Views;

namespace Lagerverwaltung
{
	static class Program
	{
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

            //Test

            //LoginForm
            var login = new Login();
            var splash = new SplashScreen();
            if (login.ShowDialog() == DialogResult.OK)
            {
                splash.ShowDialog();
                Application.Run(new Dashboard());
            }
        }
    }
}
