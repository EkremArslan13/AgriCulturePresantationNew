using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Description1).NotEmpty().WithMessage("Açıklama 1 boş geçilemez");
            RuleFor(x => x.Description2).NotEmpty().WithMessage("Açıklama 2 boş geçileme");
            RuleFor(x => x.Description3).NotEmpty().WithMessage("Açıklama 3 boş geçileme");
            RuleFor(x => x.Description4).NotEmpty().WithMessage("Açıklama 4 boş geçilemez");
            RuleFor(x => x.MapInfo).NotEmpty().WithMessage("Harita bilgisi boş geçilemez");
            RuleFor(x => x.Description1).MaximumLength(25).WithMessage("Lütfen açıklamayı kısaltın");
            RuleFor(x => x.Description1).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapın");
            RuleFor(x => x.Description2).MaximumLength(25).WithMessage("Lütfen açıklamayı kısaltın");
            RuleFor(x => x.Description2).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapın");
            RuleFor(x => x.Description3).MaximumLength(25).WithMessage("Lütfen açıklamayı kısaltın");
            RuleFor(x => x.Description3).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapın");
            RuleFor(x => x.Description4).MaximumLength(25).WithMessage("Lütfen açıklamayı kısaltın");
            RuleFor(x => x.Description4).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapın");


        }
    }
}
