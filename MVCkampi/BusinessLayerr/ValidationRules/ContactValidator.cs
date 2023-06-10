using EntityLayerr.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerr.ValidationRules
{
    public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator() 
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail Boş Geçemezsin");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Adı Boş Geçemezsin");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı Boş Geçemezsin");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("en az e karekter olmalı");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("en az e karekter olmalı");
            RuleFor(x => x.Subject).MaximumLength(20).WithMessage("en fazla 20 karekter olmalı");
            
        }
    }
}
