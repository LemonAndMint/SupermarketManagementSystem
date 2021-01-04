using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem.database
{
	class DebitSale : Sale
	{
		[Key]
		public int customer_no { get; set; }

		public virtual Employee Employee { get; set; }
		public virtual CustomerDebt CustomerDebt { get; set; }
	}
}
