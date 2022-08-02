using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact2>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Kullanıcı Maili Boş Geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Boş Bırakılamaz");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı Boş Geçilemez");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("En Az 3 Karakter Girişi Yapın");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("En az 3 Karakter Girilebilir");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("En Fazla 50 Karakter Girişi Yapın");

        }
    }
}