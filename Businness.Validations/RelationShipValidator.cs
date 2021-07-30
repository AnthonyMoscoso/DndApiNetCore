using FluentValidation;
using Models.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businness.Validations
{
    public class RelationShipValidator : AbstractValidator<RelationshipDto>
    {
        public RelationShipValidator()
        {
            RuleFor(w => w.Character).NotNull().WithErrorCode("400").WithMessage("");
            RuleFor(w => w.Character1).NotNull().WithErrorCode("400").WithMessage("");
            RuleFor(w => w.RelationType).NotNull().WithErrorCode("400").WithMessage("");
        }
    }
}
