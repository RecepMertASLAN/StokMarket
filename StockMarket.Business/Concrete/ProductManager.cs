using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockMarket.Business.Abstract;
using StockMarket.Business.Utilities;
using StockMarket.Business.ValidationRules.FluentValidation;
using StockMarket.DataAccess.Abstract;
using StockMarket.DataAccess.Concrete.EntityFramework;
using StockMarket.Entities.Concrete;

namespace StockMarket.Business.Concrete
{
	public class ProductManager:IProductService
	{
		private IProductDal _productDal;

		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}

		public void Add(Product product)
		{
			ValidationTool.Validate(new ProductValidator(), product);
			_productDal.Add(product);
		}

		public List<Product> GetProducts()
		{
			return _productDal.GetList();
		}

		public List<Product> GetProductsBySupplierId(int supplierId)
		{
			return _productDal.GetList(p => p.SupplierId == supplierId);
		}

		public void Update(Product product)
		{
			_productDal.Update(product);
		}

		public List<Product> GetProductByProductName(string productName)
		{
			return _productDal.GetList(p => p.ProductName.ToLower().Contains(productName.ToLower()));
		}

		public List<Product> GeProductsByCategory(int categoryId)
		{
			return _productDal.GetList(p => p.CategoryId == categoryId);
		}


	}
}
