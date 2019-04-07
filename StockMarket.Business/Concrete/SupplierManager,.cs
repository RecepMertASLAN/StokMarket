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
	public class SupplierManager:ISupplierService
	{
		private ISupplierDal _supplierDal;

		public SupplierManager(ISupplierDal supplierDal)
		{
			_supplierDal = supplierDal;
		}

		public List<Supplier> GetSuppliers()
		{
			return _supplierDal.GetList();
		}

		public void Add(Supplier supplier)
		{
			_supplierDal.Add(supplier);
		}

		public void Update(Supplier supplier)
		{
			_supplierDal.Update(supplier);
		}


		public void Delete(Supplier supplier)
		{

		}

		
	}

}
