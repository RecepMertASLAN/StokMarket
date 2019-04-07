using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockMarket.Entities.Concrete;

namespace StockMarket.Business.Abstract
{
	public interface ICategoryService
	{
		List<Category> GetCategories();
		void Add(Category category);
		void Update(Category category);
		
	}
}
