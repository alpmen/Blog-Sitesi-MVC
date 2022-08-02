using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Boş Bırakılamaz");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Soyadı Boş Geçilemez");
            RuleFor(x => x.writerAbout).NotEmpty().WithMessage("Hakkımda Kısmı Boş Geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(3).WithMessage("En Az 2 Karakter Girişi Yapın");
            RuleFor(x => x.WriterSurname).MaximumLength(55).WithMessage("En Fazla 50 Karakter Girilebilir");
            RuleFor(x => x.WriterImage).MaximumLength(249).WithMessage("En Fazla 250 Karakter Girilebilir");

        }
       
    }
}
