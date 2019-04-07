using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockMarket.Entities.Concrete;

namespace StockMarket.Business.Abstract
{
	public interface ISupplierService
	{
		List<Supplier> GetSuppliers();
		
		void Add(Supplier supplier);

		void Update(Supplier supplier);

		void Delete(Supplier supplier);
		
	}
}
