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
	class Product
	{

		public int waybill_no { get; set; }
		[Key]
		public long barcode { get; set; }
		public int supplier_no { get; set; }
		public int product_no { get; set; }
		public int unit_input_price { get; set; }
		public float  prize { get; set; }
		public int amount { get; set; }

		public virtual MarketDebt MarketDebt { get; set; }
		public virtual Sale Sale { get; set; }
		public virtual Supplier Supplier { get; set; }

		public static Product getProductbyBarcode(long barcode)
		{

			Product productInfo;

			using ( MngContext context = new MngContext()){

				productInfo = context.Products.SqlQuery("Select * from Products where barcode=@bcd", new SqlParameter("@bcd", barcode)).FirstOrDefault<Product>();

			}

			return productInfo;
		}

		public static Product getProductbyProductNo(int product_no)
		{

			Product productInfo;

			using (MngContext context = new MngContext())
			{

				productInfo = context.Products.SqlQuery("Select * from Products where product_no=@pdcno", new SqlParameter("@pdcno", product_no)).FirstOrDefault<Product>();

			}

			return productInfo;
		}

		public static void setProduct(int waybill_no, long barcode, 
																	int supplier_no, int product_no, 
																	int unit_input_price, int amount,
																	float prize, DateTime debt_date)
		{

			if (getProductbyBarcode(barcode) == null)
			{ //eklenecek ürünün database de olup olmadığınıa bakılır. 

				using (MngContext context = new MngContext())
				{

					Product p = new Product
					{
						waybill_no = waybill_no,
						barcode = barcode,
						supplier_no = supplier_no,
						product_no = product_no,
						unit_input_price = unit_input_price,
						amount = amount,
						Supplier = Supplier.setSupplier(supplier_no),
					};

					p.MarketDebt = MarketDebt.setMDebt(barcode, prize, debt_date, p);

					context.Products.Add(p);
					context.SaveChanges();

				}

			}

		}

	}

}
