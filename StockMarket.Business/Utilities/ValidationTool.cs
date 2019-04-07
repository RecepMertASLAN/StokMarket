using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace StockMarket.Business.Utilities
{
	public static class ValidationTool // Bu class i hep kullanacagimiz icin static yapiyorun.
	{
		public static void Validate(IValidator _validator,object entity) // Ivalidatior Gonder Bana BU IValidator FluentValidation in icinde bulunan AbstractValidator sinifinin base aldigi Bir INterfacetir
			// Bu interface Sayesinde Ister ProductValidator istersek te baska bir Validator gonderebiliriz.
			// Ivalidator dusunde bir Entity istiyor bizden bizde bunun icin Object veriyorz Herkesin Annesi sonucta.
		{
			var result = _validator.Validate(entity); // Kontrolunu sagliyoruz
			if (result.Errors.Count>0) // Eger result in icndeki hatalar 0 dan buyukse hata var demektir. Eger Buyuk degilse demekki hata yoktur,
			{
				throw  new ValidationException(result.Errors);
			}
		}
	}
}
