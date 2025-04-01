using FluentValidation;
using Yummy.Entities;

namespace Yummy.ValidationRules
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adını boş geçmeyin");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("En az 2 karekter veri girişi yapınız");
            RuleFor(x=>x.ProductName).MaximumLength(50).WithMessage("En fazla 50 karekter veri girişi yapınız");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün fiyatı boş geçilemez").GreaterThan(0).WithMessage("Ürün fiyatı negatif olamaz").LessThan(1000).WithMessage("Ürün fiyatı bu kadar yükseksek olamaz, giridğiniz değeri kontrol ediniz");
            RuleFor(x => x.ProductDescription).NotEmpty().WithMessage("Ürün acıklaması boş geçilemez");
        }
    }
}
