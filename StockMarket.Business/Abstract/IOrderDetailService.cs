using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockMarket.Entities.Concrete;

namespace StockMarket.Business.Abstract
{
	public interface IOrderDetailService
	{
		void Add(OrderDetail orderDetail);
		List<OrderDetail> GetDetails();
		List<OrderDetail> GetDetailsByOrderId(int orderId);
	}
}
