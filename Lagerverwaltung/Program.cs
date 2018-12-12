using System;
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

            var login = new Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Dashboard(Controller.AuthenticationController.Adminuser));
            }
        }
    }
}
