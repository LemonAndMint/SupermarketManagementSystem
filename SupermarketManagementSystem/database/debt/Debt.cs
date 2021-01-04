using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem.database
{
	class Debt
	{
		public int debt_amount { get; set; }
		public bool payed { get; set; } //borç ödendiyse true olacak 
		public DateTime debt_date { get; set; }

	}
}
