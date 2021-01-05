using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem.database
{
	class DebitSale : Sale
	{
		[Key, Column(Order = 0)]
		public int customer_no { get; set; }
		[Key, Column(Order = 1)]
		public string username { get; set; }

		[Required]
		public virtual Employee Employee { get; set; }
		public virtual CustomerDebt CustomerDebt { get; set; }

		/*public static DebitSale getDebitSale(string customer_no)
		{

			DebitSale debitInfo;

			using (var context = new MngContext())
			{

				debitInfo = context.Employees.SqlQuery("Select sale_no, product_no, sale_date, payment_method from Employees where username=@usr and password=@pwd", new SqlParameter("@usr", dusername), new SqlParameter("@pwd", dpassword)).FirstOrDefault<Employee>();

			}

			return debitInfo;
		}*/


	}
}
