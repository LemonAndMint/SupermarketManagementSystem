using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem.database
{
	class DebitSale : Sale
	{
		[Key]
		public int customer_no { get; set; }

		[Required]
		public virtual Employee Employee { get; set; }
		public virtual CustomerDebt CustomerDebt { get; set; }
		public virtual Product Product { get; set; }

		public static DebitSale getDebitSale(int customer_no)
		{

			DebitSale debitInfo;

			using (var context = new MngContext())
			{

				debitInfo = context.DebitSales.SqlQuery("Select sale_no, product_no, sale_date, payment_method from Employees where customer_no=@cno", new SqlParameter("@usr", customer_no)).FirstOrDefault<DebitSale>();

			}

			return debitInfo;
		}

		public static void setDSale(int customer_no, int sale_no, int product_no,
																DateTime sale_date, string payment_method,
																string empusname, int barcode, int prize)
		{
			using (MngContext context = new MngContext())
			{

				DebitSale m = new DebitSale
				{
					sale_no = sale_no,
					product_no = product_no,
					sale_date = sale_date,
					payment_method = payment_method,
					Employee = Employee.getEmployeebyUsName(empusname),
					Product = Product.getProductbyBarcode(barcode),
				};

				m.CustomerDebt = CustomerDebt.setCDebt(customer_no, prize, sale_date, m);

				context.DebitSales.Add(m);
				context.SaveChanges();

			}

		}


	}
}
