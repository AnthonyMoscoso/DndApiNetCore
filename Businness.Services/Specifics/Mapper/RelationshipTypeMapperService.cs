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
    public class RelationshipTypeMapperService : MapperBaseService<RelationShipTypeDto, RelationShip> , IRelationShipTypeService
    {
        readonly new IRelationShipRepository _repository;
        public RelationshipTypeMapperService(IRepository<RelationShip> repository, IMapper mapper, IValidator<RelationShipTypeDto> validator) : base(repository, mapper, validator)
        {
        }
    }
}
