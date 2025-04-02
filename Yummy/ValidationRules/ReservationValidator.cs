using FluentValidation;
using Yummy.Entities;

namespace Yummy.ValidationRules
{
    public class ReservationValidator:AbstractValidator<Reservation>
    {
        public ReservationValidator()
        {
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("İsim ve soyisiminiz doldurunuz");
            RuleFor(x => x.NameSurname).MinimumLength(2).WithMessage("İsiminiz en az 2 karekterden fazla olmaılıdır");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Telefon numaranızı doldurunuz");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanını doldurunuz");
            RuleFor(x => x.ReservationDate).NotEmpty().WithMessage("Rezervasyon tarihini doldurunuz");
            RuleFor(x => x.ReservationTime).NotEmpty().WithMessage("Rezervasyon saatini doldurunuz");
            RuleFor(x => x.CountofPeople).NotEmpty().WithMessage("kişi sayısı boş geçilemez").GreaterThan(0).WithMessage("kişi sayısı negatif olamaz").LessThan(10).WithMessage("En fazla 10 kişilik yer ayırtabilirsiniz");
        }
    }
}
