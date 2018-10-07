using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
			Login login = new Login();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(login);

			//if(login.Adminuser==true)...
		}
		#endregion
		#region private

		#endregion
	}
}
