using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem.database
{
	class Supplier
	{
		public int supplier_no { get; set; }

		public virtual ICollection<Product> Products { get; set; }
	}
}
