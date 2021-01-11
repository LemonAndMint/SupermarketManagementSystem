using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem.database
{
	class MarketDebt : Debt
	{
		[Key]
		public int m_debt_no { get; set; }
		
		public virtual Product Product { get; set; }

		public static List<MarketDebt> getMDebtnonPayed() 
		{ //toplam market borcu

			List<MarketDebt> debtInfo;

			using (MngContext context = new MngContext())
			{

				debtInfo = context.MarketDebts.SqlQuery("Select * from MarketDebts where payed=false").ToList();

			}

			return debtInfo;

		}

		public static MarketDebt setMDebt(float debt_amount,
																			DateTime debt_date)
		{
			using (MngContext context = new MngContext())
			{

				MarketDebt m = new MarketDebt
				{
					debt_amount = debt_amount,
					debt_date = debt_date,
					payed = false, //ürün stoğa eklendiğinde borç oluşur daima
				};

				context.MarketDebts.Add(m);
				context.SaveChanges();

				return m;

			}

		}

		public static float totalMDebt()
		{
			List<MarketDebt> marketDebts = getMDebtnonPayed();

			float totalDebt = 0;
			
			foreach (MarketDebt debt in marketDebts)
			{
				//zaten getMDebtnonPayed() metodunda ödenmemiş borçlar alındığı için 
				//borcun ödenip ödenmediği kontrolü yapılmaz.
				totalDebt += debt.debt_amount;

			}

			return totalDebt;

		}

	}

}
