using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using StockMarket.Entities.Abstract;

namespace StockMarket.Entities.Concrete
{
	public class OrderDetail :IEntity
	{
		[Key]
		public int OrderId { get; set; }
		public virtual Order Order { get; set; }

	
		public int ProductId { get; set; }
		public virtual Product Product { get; set; }
		
		public decimal UnitPrice { get; set; }
		public Int16 Quantity { get; set; }
		public int Discount { get; set; }

		
		
	}
}
