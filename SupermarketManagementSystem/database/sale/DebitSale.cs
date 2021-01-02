using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem.database
{
	class DebitSale : Sale
	{
		public int customer_no { get; set; }

		public virtual Employee Employee { get; set; }
	}
}
