using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem.database.sale
{
	class CashSale : Sale
	{
		public virtual Employee Employee { get; set; }
	}
}
