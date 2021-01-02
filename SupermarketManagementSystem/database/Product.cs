using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem.database
{
	class Product
	{
		public int waybill_no { get; set; }
		public int supplier_no { get; set; }
		public int product_no { get; set; }
		public int barcode { get; set; }
		public int unit_input_price { get; set; }
		public int amount { get; set; }

		public virtual MarketDebt MarketDebt { get; set; }
		public virtual Sale Sale { get; set; }
		public virtual Supplier Supplier { get; set; }
	}
}
