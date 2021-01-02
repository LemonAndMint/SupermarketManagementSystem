using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem.database
{
	class Sale
	{
		public int sale_no { get; set; }
		public int product_no { get; set; }
		public DateTime sale_date { get; set; }
		public string payment_method { get; set; }
	}
}
