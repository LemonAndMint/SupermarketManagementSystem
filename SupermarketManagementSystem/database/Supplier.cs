using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem.database
{
	class Supplier
	{
		[Key]
		public int supplier_no { get; set; }

		public virtual ICollection<Product> Products { get; set; }
	}
}
