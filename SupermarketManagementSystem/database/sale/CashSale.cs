using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketManagementSystem.database;

namespace SupermarketManagementSystem.database.sale
{
	class CashSale : Sale
	{
		public virtual Employee Employee { get; set; }
		public virtual Product Product { get; set; }

		public static CashSale getCSalebyNo(string sale_no)
		{

			CashSale cSaleInfo;

			using (var context = new MngContext())
			{

				cSaleInfo = context.CashSales.SqlQuery("Select product_no, sale_date, payment_method from CashSales where sale_no=@sale", new SqlParameter("@sale", sale_no)).FirstOrDefault<CashSale>();

			}

			return cSaleInfo;
		}

		public static CashSale getCSalebydate(DateTime sale_date)
		{

			CashSale cSaleInfo;

			using (var context = new MngContext())
			{

				cSaleInfo = context.CashSales.SqlQuery("Select sale_no, product_no, payment_method from CashSales where sale_date=@sldt", new SqlParameter("@sldt", sale_date)).FirstOrDefault<CashSale>();

			}

			return cSaleInfo;
		}

		public static List<CashSale> getallCSale()
		{

			List<CashSale> cSaleInfo;

			using (var context = new MngContext())
			{

				cSaleInfo = context.CashSales.SqlQuery("Select product_no, sale_date, payment_method from CashSales where sale_no=@sale").ToList();

			}

			return cSaleInfo;
		}
		public static void setCSale(int sale_no, int product_no,
																DateTime sale_date, string payment_method,
																string empusname,  int barcode)
		{
			using (MngContext context = new MngContext())
			{

				CashSale m = new CashSale
				{
					sale_no = sale_no,
					product_no = product_no,
					sale_date = sale_date,
					payment_method = payment_method,
					Employee = Employee.getEmployeebyUsName(empusname),
					Product = Product.getProductbyBarcode(barcode),
				};

				context.CashSales.Add(m);
				context.SaveChanges();

			}

		}
	}
}
