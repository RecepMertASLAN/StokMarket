using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using StockMarket.Entities.Concrete;

namespace StockMarket.Business.ValidationRules.FluentValidation
{
	public class ProductValidator : AbstractValidator<Product> // Product Icin Kurallar Gerceklestirecegim. // FluentValidation ile calisiyoruz ondan FluentValidation Klasorumuz Var
	{
		public ProductValidator()
		{
			RuleFor(p => p.ProductName).MaximumLength(50);
			

		}
	}
}
