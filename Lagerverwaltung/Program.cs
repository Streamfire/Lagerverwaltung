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
            Thread splashThread = new Thread(new ThreadStart(() => { Application.Run(splash); }));
            splashThread.SetApartmentState(ApartmentState.STA);
            if (login.ShowDialog() == DialogResult.OK)
            {
                splashThread.Start();
            }
            if(splashThread.IsAlive)
            {
                splashThread.Join();
                Application.Run(new Dashboard());
            }
        }
    }
}
