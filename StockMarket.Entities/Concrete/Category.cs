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
	public class Category :IEntity		
	{
		public Category()
		{
			this.Products = new HashSet<Product>();
		}
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
		public string Description { get; set; }
		public byte[] Picture { get; set; }

	//	[ForeignKey("CategoryId")]
		public virtual ICollection<Product> Products { get; set; }
	}
}
