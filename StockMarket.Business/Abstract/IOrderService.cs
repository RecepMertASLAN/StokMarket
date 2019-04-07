using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockMarket.Entities.Concrete;

namespace StockMarket.Business.Abstract
{
	public interface IOrderService
	{
		void Add(Order order);
		Order GetOrderId(DateTime time);
		List<Order> GetOrders();
	}
}
