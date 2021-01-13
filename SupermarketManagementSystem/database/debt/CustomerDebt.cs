using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem.database
{
	class CustomerDebt : Debt
	{
		[Key]
		public int customer_no { get; set; }

		public virtual DebitSale DebitSale { get; set; }

		public static CustomerDebt getSupplier(int customer_no)
		{

			CustomerDebt cDebtInfo;

			using (MngContext context = new MngContext())
			{

				cDebtInfo = context.CustomerDebts.SqlQuery("Select * from CustomerDebts where customer_no=@cno", new SqlParameter("@cno", customer_no)).FirstOrDefault<CustomerDebt>();

			}

			return cDebtInfo;

		}

		public static CustomerDebt setCDebt(int customer_no, int debt_amount,
																				DateTime debt_date)
		{
			if (getSupplier(customer_no) == null) { 
					using (MngContext context = new MngContext())
				{

					CustomerDebt m = new CustomerDebt
					{
						customer_no = customer_no,
						debt_amount = debt_amount,
						debt_date = debt_date,
						payed = false, //ürün stoğa eklendiğinde borç oluşur daima
					};

					context.CustomerDebts.Add(m);
					context.SaveChanges();

					return m;

				}
			}
			return null;
		}

	}

}
