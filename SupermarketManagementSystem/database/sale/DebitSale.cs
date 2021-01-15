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
	class DebitSale
	{
		[Key]
		public int sale_no { get; set; }
		public int customer_no { get; set; }
		public int barcode { get; set; }
		public float prize { get; set; }
		public float unit_input_price { get; set; }
		public int product_no { get; set; }
		public DateTime sale_date { get; set; }
		public string payment_method { get; set; }

		[Required]
		public virtual Employee Employee { get; set; }
		[Required]
		public virtual CustomerDebt CustomerDebt { get; set; }

		public static DebitSale getDebitSale(int customer_no)
		{

			DebitSale debitInfo;

			using (var context = new MngContext())
			{

				debitInfo = context.DebitSales.SqlQuery("Select * from DebitSales where customer_no=@cno", new SqlParameter("@cno", customer_no)).FirstOrDefault<DebitSale>();

			}

			return debitInfo;
		}
		public static List<DebitSale> getallDSale()
		{

			List<DebitSale> dSaleInfo;

			using (var context = new MngContext())
			{

				dSaleInfo = context.DebitSales.SqlQuery("Select * from DebitSales").ToList();

			}

			return dSaleInfo;
		}

		public void DebtSoldProducts()
		{


		}


		public static void setDSale(int customer_no, int sale_no, int product_no, float unit_input_price,
																DateTime sale_date, string payment_method,
																string empusname, int barcode, float prize)
		{
			using (MngContext context = new MngContext())
			{

				Employee e = Employee.getEmployeebyUsName(empusname);

				DebitSale m = new DebitSale
				{
					customer_no = customer_no,
					sale_no = sale_no,
					prize = prize,
					unit_input_price = unit_input_price,
					product_no = product_no,
					sale_date = sale_date,
					payment_method = payment_method,
					Employee = e,
				};
				m.CustomerDebt = CustomerDebt.setCDebt(customer_no, prize, sale_date, sale_no);

				context.DebitSales.Add(m);
				context.SaveChanges();

			}

		}


	}
}
