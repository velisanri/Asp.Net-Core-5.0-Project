﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator() 
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığın boş geçemezsiniz");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriğini geçemezsiniz");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog Resmini boş geçemezsiniz");
        }
    }
}
