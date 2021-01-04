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
		[Key, Column(Order = 0)]
		public int waybill_no { get; set; }
		[Key, Column(Order = 1)]
		public int barcode { get; set; }
		public int supplier_no { get; set; }
		public int product_no { get; set; }
		public int unit_input_price { get; set; }
		public int amount { get; set; }

		public virtual MarketDebt MarketDebt { get; set; }
		public virtual Sale Sale { get; set; }
		public virtual Supplier Supplier { get; set; }

		public static Product getProductbyBarcode(int barcode)
		{

			Product productInfo;

			using ( MngContext context = new MngContext()){

				productInfo = context.Products.SqlQuery("Select barcode from Products where barcode=@bcd", new SqlParameter("@bcd", barcode)).FirstOrDefault<Product>();

			}

			return productInfo;
		}

		public static Product getProductbyProductNo(int product_no)
		{

			Product productInfo;

			using (MngContext context = new MngContext())
			{

				productInfo = context.Products.SqlQuery("Select product_no from Products where product_no=@pdcno", new SqlParameter("@pdcno", product_no)).FirstOrDefault<Product>();

			}

			return productInfo;
		}

		public static void setProduct(int waybill_no, int barcode, 
																	int supplier_no, int product_no, 
																	int unit_input_price, int amount)
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
					};

					context.Products.Add(p);
					context.SaveChanges();

				}

			}

		}

	}

}
