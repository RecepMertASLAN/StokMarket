using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using StockMarket.DataAccess.Abstract;
using StockMarket.Entities.Abstract;

namespace StockMarket.DataAccess.Concrete.EntityFramework
{
	public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
	{

		public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
		{
			using (TContext context = new TContext())
			{
				return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
			}
		}
		//kendoUI
		public TEntity Get(Expression<Func<TEntity, bool>> filter)
		{
			using (TContext context = new TContext())
			{
				return context.Set<TEntity>().SingleOrDefault(filter);
			}
		}

		public void Add(TEntity entity)
		{
			using (TContext context = new TContext())
			{
				context.Entry(entity).State = EntityState.Added;
				context.SaveChanges();
			}
		}

		public void Update(TEntity entity)
		{
			using (TContext context = new TContext())
			{
				context.Entry(entity).State = EntityState.Modified;
				context.SaveChanges();
			}
		}

		public void Delete(TEntity entity)
		{
			using (TContext context = new TContext())
			{
				context.Entry(entity).State = EntityState.Deleted;
				context.SaveChanges();
			}
		}
	}
}
