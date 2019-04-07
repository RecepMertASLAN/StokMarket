using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockMarket.Entities.Concrete;

namespace StockMarket.Business.Abstract
{
	public interface IProductService
	{
		List<Product> GeProductsByCategory(int categoryId);

		void Add(Product product);
		List<Product> GetProducts();
		List<Product> GetProductsBySupplierId(int categoryId);
		void Update(Product product);
		List<Product> GetProductByProductName(string productName);
	}
}
