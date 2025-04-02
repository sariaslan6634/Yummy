using FluentValidation;
using Yummy.Entities;

namespace Yummy.ValidationRules
{
    public class TestimonialValidator:AbstractValidator<Testimonial>
    {
        public TestimonialValidator()
        {
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("Referans adını boş geçmeyin").MaximumLength(25).WithMessage("En fazla 25 karekter giriniz.").MinimumLength(2).WithMessage("En az 2 karekter giriniz");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlığı doldurunuz.");
            RuleFor(x => x.Comment).NotEmpty().WithMessage("Acıklamayı doldurunuz.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim seciniz");
        }
    }
}
