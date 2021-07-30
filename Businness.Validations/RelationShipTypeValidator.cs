using FluentValidation;
using Models.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businness.Validations
{
    public class RelationShipTypeValidator : AbstractValidator<RelationShipTypeDto>
    {
        public RelationShipTypeValidator()
        {
            RuleFor(w => w.RelationName).NotEmpty().WithErrorCode("400").WithMessage("");
            RuleFor(w=> w.Description).NotNull().NotEmpty().WithErrorCode("400").WithMessage("");
        }
    }
}
