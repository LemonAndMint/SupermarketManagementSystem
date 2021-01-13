using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupermarketManagementSystem.database;
using SupermarketManagementSystem.database.sale;

namespace SupermarketManagementSystem
{
	static class Program
	{
		/// <summary>
		/// Uygulamanın ana girdi noktası.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Employee.setEmployee("aa", "123");


			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());

		}
	}
}
