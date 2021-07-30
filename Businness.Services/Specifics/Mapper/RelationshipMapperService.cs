using AutoMapper;
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
    public class RelationshipMapperService : MapperBaseService<RelationshipDto, RelationShip>
    {
        readonly new IRelationShipRepository _repository;
        public RelationshipMapperService(IRelationShipRepository repository, IMapper mapper, IValidator<RelationshipDto> validator) : base(repository, mapper, validator)
        {
        }
    }
}
