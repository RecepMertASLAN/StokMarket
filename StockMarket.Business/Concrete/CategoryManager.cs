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
	public class CategoryManager :ICategoryService
	{
		private ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public List<Category> GetCategories()
		{
			return _categoryDal.GetList();
		}

		public void Add(Category category)
		{
			_categoryDal.Add(category);
		}

		public void Update(Category category)
		{
			_categoryDal.Update(category);
		}

		
	}
}
