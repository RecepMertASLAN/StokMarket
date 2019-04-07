using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using StockMarket.Entities.Abstract;

namespace StockMarket.Entities.Concrete
{
	public class Order :IEntity
	{
		public Order()
		{
			this.OrderDetails = new HashSet<OrderDetail>();
		}
		public int OrderId { get; set; }
		public DateTime OrderDate { get; set; }
		public  decimal TotalPrice { get; set; }

	//	[ForeignKey("OrderId")]
		public virtual ICollection<OrderDetail> OrderDetails { get; set; }

	}
}
