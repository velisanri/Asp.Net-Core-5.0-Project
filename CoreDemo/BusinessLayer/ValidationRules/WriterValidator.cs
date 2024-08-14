﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Soyadı Kısmı boş geçilemez");

            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail Adresi Boş geçilemez");

            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez");

            
        }
    }
}
