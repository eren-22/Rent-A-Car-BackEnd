﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(1);
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.ModelYear).LessThanOrEqualTo(DateTime.Now.Year).WithMessage("Geçersiz yıl!");
        }
    }
}