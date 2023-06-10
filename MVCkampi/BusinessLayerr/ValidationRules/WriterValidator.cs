using EntityLayerr.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerr.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterAbout).Must(x => x != null && x.ToUpper().Contains("A")).WithMessage("isminde A harfi olmalıdır");
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsiniz");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Soyadını Boş Geçemezsiniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında kısmını Boş Geçemezsiniz");
            RuleFor(x => x.WriterSurName).MinimumLength(5).WithMessage("En az 5 karakter olmalı");
            RuleFor(x => x.WriterSurName).MaximumLength(15).WithMessage("En fazla 15 karakter olmalı");
            
        }
    }
}
