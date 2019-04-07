using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using StockMarket.DataAccess.Abstract;
using StockMarket.Entities.Concrete;

namespace StockMarket.DataAccess.Concrete.EntityFramework
{
	public class EfSupplierDal : EfEntityRepositoryBase<Supplier, StockMarketContext>, ISupplierDal
	{

	}
}
