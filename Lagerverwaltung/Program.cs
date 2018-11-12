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

            //Test

            //LoginForm
            Login login = new Login();
			Application.Run(login);
			//Dashboard
			Dashboard board = new Dashboard(login.Adminuser);
			Application.Run(board);
		}
	}
}
