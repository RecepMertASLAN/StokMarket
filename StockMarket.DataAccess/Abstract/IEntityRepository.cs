using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using StockMarket.Entities.Abstract;

namespace StockMarket.DataAccess.Abstract
{
	public interface IEntityRepository<T> where  T: class,IEntity,new()
	{
		List<T> GetList(Expression<Func<T, bool>> filter = null);
		T Get(Expression<Func<T, bool>> filter);
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);
	 
	}

	
}
	