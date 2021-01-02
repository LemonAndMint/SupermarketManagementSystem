using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem.database
{
	class MarketDebt : Debt	
	{
		public int product_no { get; set; }

		public virtual Product Product { get; set; }
	}
}
