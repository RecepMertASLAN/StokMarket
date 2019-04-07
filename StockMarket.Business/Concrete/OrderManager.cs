using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockMarket.Business.Abstract;
using StockMarket.DataAccess.Abstract;
using StockMarket.Entities.Concrete;

namespace StockMarket.Business.Concrete
{
	public class OrderManager:IOrderService
	{
		private IOrderDal _orderDal;

		public OrderManager(IOrderDal orderDal)
		{
			_orderDal = orderDal;
		}

		public void Add(Order order)
		{
			_orderDal.Add(order);
		}

		public Order GetOrderId(DateTime time)
		{
		
			return _orderDal.Get(p => p.OrderDate == time);
		}

		public List<Order> GetOrders()
		{
			return _orderDal.GetList();
		}
	}
}
