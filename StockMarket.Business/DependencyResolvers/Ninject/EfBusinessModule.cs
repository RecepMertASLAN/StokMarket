using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using StockMarket.Business.Abstract;
using StockMarket.Business.Concrete;
using StockMarket.DataAccess.Abstract;
using StockMarket.DataAccess.Concrete.EntityFramework;

namespace StockMarket.Business.DependencyResolvers.Ninject
{
	public class EfBusinessModule : NinjectModule
	{
		public override void Load() // Yarin birgun yeni bir nhibernate e falan gecersek sadece degistirmemiz gereken yer burasidir.
		{
			Bind<IProductService>().To<ProductManager>().InSingletonScope(); // Biri Senden IProductService Isterse Ona Product Manger Olustur Onu don demek. 
																			 // In InSingletonScope diyerek sadece nesnenin bir kere yaratilmasini saglamis olluyoruz.
			Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

			// Category
			Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();

			Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();

			// Supplier
			Bind<ISupplierService>().To<SupplierManager>().InSingletonScope();

			Bind<ISupplierDal>().To<EfSupplierDal>().InSingletonScope();

			// OderDetail
			Bind<IOrderDetailService>().To<OrderDetailManager>().InSingletonScope();

			Bind<IOrderDetailDal>().To<EfOrderDetailDal>().InSingletonScope();

			// Order
			Bind<IOrderService>().To<OrderManager>().InSingletonScope();

			Bind<IOrderDal>().To<EfOrderDal>().InSingletonScope();


		}
	}
}
