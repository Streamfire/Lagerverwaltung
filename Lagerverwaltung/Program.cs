using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lagerverwaltung.Views;

namespace Lagerverwaltung
{
	static class Program
	{
		#region public
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main()
		{
			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			//LoginForm
			Login login = new Login();
			Application.Run(login);
			//Dashboard
			Dashboard board = new Dashboard(login.Adminuser);
			Application.Run(board);
		}

		#endregion
		#region private
		#endregion
	}
}
