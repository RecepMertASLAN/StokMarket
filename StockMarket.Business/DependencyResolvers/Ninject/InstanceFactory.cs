using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;

namespace StockMarket.Business.DependencyResolvers.Ninject
{
	public class InstanceFactory
	{
		public static T GetInstance<T>() // Method un generic yapilmasi ile calisacagim yapiyi soyluyorun. IProductService,IProductDal gibi 
										 // Burada Generic Method ile iste calisacagimiz new EfBusinessModule  soyledik ya O bize gene T donuyor o donus nedir dersek O Hani implementasyon yaptik ya ona bagli bisey olabilir. Yani Verdigimiz seyin Concrete i 
		{ // calisma Mantigi Su sekilde: Ben IProductDal ile calismak istiyorum dersem Get<T> EfBusinessModule un icine gidicek Senin icinde IProductDal var mi dicek varsa onun new ini olusturup Return edecek. O donen de suan EfProductDal olacaktir.

			var kernel = new StandardKernel(new EfBusinessModule()); 
			return kernel. Get<T>();		
		}
	}
}
