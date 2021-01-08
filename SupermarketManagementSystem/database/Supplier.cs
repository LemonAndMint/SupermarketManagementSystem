using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem.database
{
	class Supplier
	{
		[Key]
		public int supplier_no { get; set; }

		public virtual ICollection<Product> Products { get; set; }

		public static Supplier getSupplier(int supplier_no)
		{

			Supplier supplierInfo;

			using (MngContext context = new MngContext())
			{

				supplierInfo = context.Suppliers.SqlQuery("Select * from Suppliers where supplier_no=@sno", new SqlParameter("@sno", supplier_no)).FirstOrDefault<Supplier>();

			}

			return supplierInfo;

		}

		public static Supplier setSupplier(int supplier_no)
		{

			if (getSupplier(supplier_no) == null)
			{ //eklenecek firmanın database de olup olmadığınıa bakılır. 

				using (var context = new MngContext())
				{

					Supplier e = new Supplier
					{
						supplier_no = supplier_no,
					};

					context.Suppliers.Add(e);
					context.SaveChanges();

					return e;

				}

			}
			return null;
		}
	}
}
