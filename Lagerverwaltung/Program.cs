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
            var liste = Model.HistorieModel.HoleHistorie();
            foreach(var list in liste)
            {
                Console.WriteLine("Historie {0}; User: {1}; Logtext: {2}; Zeitstempel: {3}",list.LogID,list.UserID,list.LogText,list.Zeitstempel);
            }

            //LoginForm
            Login login = new Login();
			Application.Run(login);
			//Dashboard
			Dashboard board = new Dashboard(login.Adminuser);
			Application.Run(board);
		}
	}
}
