using AutoMapper;
using Businness.Services.Abstracts;
using Core.DataAccess.Abstracts;
using Core.Services.Specifics.Mapper;
using FluentValidation;
using Infra.DataAcces.Abstracts;
using Models.Dto;
using Models.Entities.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businness.Services.Specifics.Mapper
{
    public class JobMapperService : MapperBaseService<JobDto, Job>, IJobService
    {
        readonly new IJobRepository _repository;
        public JobMapperService(IJobRepository repository, IMapper mapper, IValidator<JobDto> validator) : base(repository, mapper, validator)
        {

        }
    }
}
