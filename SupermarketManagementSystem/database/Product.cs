using SupermarketManagementSystem.database.sale;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem.database
{
	class Product
	{
		[Key]
		public int entry_no { get; set; }
		public int waybill_no { get; set; }
		public int barcode { get; set; }
		public int supplier_no { get; set; }
		public int product_no { get; set; }
		public float unit_input_price { get; set; }
		public float prize { get; set; }
		public int amount { get; set; }
		public string product_name { get; set; }

		[Required]
		public virtual MarketDebt MarketDebt { get; set; }
		public virtual ICollection<CashSale> CashSale { get; set; }
		public virtual ICollection<DebitSale> DebitSale { get; set; }
		public virtual Supplier Supplier { get; set; }

		public static Product getProductbyBarcode(int barcode)
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

		public static List<Product> getAllProduct()
		{ //toplam market borcu

			List<Product> ProductInfo;

			using (MngContext context = new MngContext())
			{

				ProductInfo = context.Products.SqlQuery("Select * from Products").ToList();

			}

			return ProductInfo;

		}

		public static void delProductByBarcode(int barcode) {

			Product del_product = getProductbyBarcode(barcode);

			if (del_product != null)
			{
				using (MngContext context = new MngContext())
				{
					context.Products.Attach(del_product);
					context.Products.Remove(del_product);
					context.SaveChanges();
				}
			}

		}

		public static void setProduct(int waybill_no, int barcode, 
																	int supplier_no, int product_no, 
																	float unit_input_price, int amount,
																	float prize, DateTime debt_date,
																	string product_name)
		{

			if (getProductbyBarcode(barcode) == null)
			{ //eklenecek ürünün database de olup olmadığınıa bakılır. 

				Supplier sup = Supplier.setSupplier(supplier_no);

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
						prize = prize,
						product_name = product_name,
						Supplier = sup,
						MarketDebt = MarketDebt.setMDebt(prize, debt_date, barcode),
				};

					context.Products.Add(p);
					context.SaveChanges();
				}

			}

		}

	}

}
