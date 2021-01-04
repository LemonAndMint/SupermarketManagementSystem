using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SupermarketManagementSystem.database
{
	class MngContext :DbContext
	{
		public MngContext() : base("MngContext") { }
		public DbSet<CustomerDebt> CustomerDebts { get; set; }
		public DbSet<MarketDebt> MarketDebts { get; set; }
		public DbSet<DebitSale> DebitSales { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Supplier> Suppliers { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			Database.SetInitializer<MngContext>(null);
			base.OnModelCreating(modelBuilder);
		}

	}
}
