using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupermarketManagementSystem.database;

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
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());

			using (var context = new MngContext())
			{

				Employee e = new Employee
				{
					username = "aa",
					password = "123",
				};
				Console.WriteLine(e.username);
				context.Employees.Add(e);
				context.SaveChanges();

			}
			
		}
	}
}
