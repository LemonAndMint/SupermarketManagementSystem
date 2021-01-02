using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem.database
{
	class Employee
	{
		public string username { get; set; }
		public string password { get; set; }

		public virtual ICollection<Sale> Sales { get; set; }
	}
}
