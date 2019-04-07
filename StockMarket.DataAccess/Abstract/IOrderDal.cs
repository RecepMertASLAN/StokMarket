using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockMarket.Entities.Concrete;

namespace StockMarket.DataAccess.Abstract
{
	public interface IOrderDal : IEntityRepository<Order>
	{
	}
}
