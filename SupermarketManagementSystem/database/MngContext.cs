using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SupermarketManagementSystem.database.sale;

namespace SupermarketManagementSystem.database
{
	class MngContext :DbContext
	{
		public MngContext() : base("name=MngContext") { }
		public DbSet<CustomerDebt> CustomerDebts { get; set; }
		public DbSet<MarketDebt> MarketDebts { get; set; }
		public DbSet<DebitSale> DebitSales { get; set; }
		public DbSet<CashSale> CashSales { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Supplier> Suppliers { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			Database.SetInitializer<MngContext>(new DropCreateDatabaseAlways<MngContext>());
			base.OnModelCreating(modelBuilder);
		}

	}
}
