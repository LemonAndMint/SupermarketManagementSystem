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
			Product.setProduct(1, 2, 3, 4, 5, 6, 7, DateTime.Now);
			CashSale.setCSale(1, 1, DateTime.Now, "nakit", "aa", 1);
			DebitSale.setDSale(1,1,1,DateTime.Now,"nakit","aa",1,1);
			Supplier.setSupplier(2);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());

		}
	}
}
