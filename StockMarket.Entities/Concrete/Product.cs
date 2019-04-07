using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockMarket.Entities.Abstract;

namespace StockMarket.Entities.Concrete
{
	public class Product :IEntity
	{
		public int ProductId { get; set; }
		
		
		public string ProductName { get; set; }
		public string QuantityPerUnit { get; set; }
		public decimal UnitPrice { get; set; }
		public Int16 UnitsInStock { get; set; }

		//[ForeignKey("ProductId")]
		public  virtual ICollection<OrderDetail> OrderDetails { get; set; }
	
		public int CategoryId { get; set; }
		public virtual Category Category { get; set; }

		public int SupplierId { get; set; }
		public virtual Supplier Supplier { get; set; }
	}
}
