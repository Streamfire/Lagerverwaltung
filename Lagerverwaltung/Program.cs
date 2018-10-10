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
			Login login = new Login();
			Application.Run(login);

			//if(login.Adminuser==true)...
		}
		#endregion
		#region private

		#endregion
	}
}
