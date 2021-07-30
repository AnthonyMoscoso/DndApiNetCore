using FluentValidation;
using Models.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businness.Validations
{
    public class CharacterValidator : AbstractValidator<CharacterDto>
    {
        public CharacterValidator()
        {
            RuleFor(w => w.Name).NotEmpty().WithErrorCode("400");
            RuleFor(w => w.Details).NotEmpty().WithErrorCode("400");
        }
    }
}
