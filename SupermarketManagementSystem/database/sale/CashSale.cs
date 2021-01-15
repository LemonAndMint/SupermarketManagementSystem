using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketManagementSystem.database;

namespace SupermarketManagementSystem.database.sale
{
	class CashSale
	{
		[Key]
		public int sale_no { get; set; }
		public int product_no { get; set; }
		public int barcode { get; set; }
		public float price { get; set; }
		public float unit_input_price { get; set; }
		public DateTime sale_date { get; set; }
		public string payment_method { get; set; }
		public virtual Employee Employee { get; set; }

		public static CashSale getCSalebyNo(string sale_no)
		{

			CashSale cSaleInfo;

			using (var context = new MngContext())
			{

				cSaleInfo = context.CashSales.SqlQuery("Select * from CashSales where sale_no=@sale", new SqlParameter("@sale", sale_no)).FirstOrDefault<CashSale>();

			}

			return cSaleInfo;
		}

		public static CashSale getCSalebydate(DateTime sale_date)
		{

			CashSale cSaleInfo;

			using (var context = new MngContext())
			{

				cSaleInfo = context.CashSales.SqlQuery("Select * from CashSales where sale_date=@sldt", new SqlParameter("@sldt", sale_date)).FirstOrDefault<CashSale>();

			}

			return cSaleInfo;
		}

		public static List<CashSale> getallCSale()
		{

			List<CashSale> cSaleInfo;

			using (var context = new MngContext())
			{

				cSaleInfo = context.CashSales.SqlQuery("Select * from CashSales").ToList();

			}

			return cSaleInfo;
		}
		public static void setCSale(int sale_no, int product_no,
																DateTime sale_date, string payment_method,
																string empusname,  int barcode)
		{

			Employee e = Employee.getEmployeebyUsName(empusname);
			Product p = Product.getProductbyBarcode(barcode);

			using (MngContext context = new MngContext())
			{

				CashSale m = new CashSale
				{
					sale_no = sale_no,
					product_no = product_no,
					barcode = barcode,
					sale_date = sale_date,
					payment_method = payment_method,
					price = p.price,
					unit_input_price = p.unit_input_price,
					Employee = e,
			};

				context.CashSales.Add(m);
				context.SaveChanges();

			}

		}
	}
}
