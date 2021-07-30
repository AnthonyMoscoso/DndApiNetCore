using FluentValidation;
using Models.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businness.Validations
{
    public class JobValidator : AbstractValidator<JobDto>
    {
        public JobValidator()
        {
            RuleFor(x => x.JobTittle).NotNull().NotEmpty().WithErrorCode("400").WithMessage("Tittle is necesary");
            RuleFor(x => x.JobDescription).NotNull().NotEmpty().WithErrorCode("400").WithMessage("Description is necesarry"); ;
        }
    }
}
