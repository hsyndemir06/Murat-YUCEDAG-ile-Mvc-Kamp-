using EntityLayerr.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerr.ValidationRules
{
    public class MessageValidator:AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Zorunlu Alan");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Zorunlu Alan");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Zorunlu Alan");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("En az 5 karaktr gir");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("En fazla 50 karaktr gir");

        }
    }
}
