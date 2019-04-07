using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockMarket.Entities.Concrete;

namespace StockMarket.DataAccess.Concrete.EntityFramework
{
	public class StockMarketContext : DbContext
	{

		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }
		public DbSet<Supplier> Suppliers { get; set; }


	}
}
