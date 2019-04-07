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
	public class OrderDetailManager : IOrderDetailService
	{
		private IOrderDetailDal _orderDetailDal;

		public OrderDetailManager(IOrderDetailDal orderDetailDal)
		{
			_orderDetailDal = orderDetailDal;
		}

		public void Add(OrderDetail orderDetail)
		{
			_orderDetailDal.Add(orderDetail);
		}

		public List<OrderDetail> GetDetails()
		{
			return _orderDetailDal.GetList();
		}

		public List<OrderDetail> GetDetailsByOrderId(int orderId)
		{
			return _orderDetailDal.GetList(p => p.OrderId == orderId).ToList();
		}
	}
}
