using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem.database
{
	class CustomerDebt : Debt
	{
		[Key]
		public int customer_no { get; set; }

		[Required]
		public virtual DebitSale DebitSale { get; set; }
	}
}
