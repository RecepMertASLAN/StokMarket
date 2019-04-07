using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockMarket.Entities.Abstract;

namespace StockMarket.Entities.Concrete
{
	public class Supplier :IEntity
	{
		public int SupplierId { get; set; }
		public string CompanyName { get; set; }
		public string ContactName { get; set; }
		public string Address { get; set; }
		public string City { get; set; }

		public string PostalCode { get; set; }
		public string District { get; set; }
		public string Phone { get; set; }

	//	[ForeignKey("SupplierId")]
		public virtual ICollection<Product> Products { get; set; }
	}
}
