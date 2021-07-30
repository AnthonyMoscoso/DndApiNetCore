using AutoMapper;
using Businness.Services.Abstracts;
using Core.DataAccess.Abstracts;
using Core.DataAccess.Specifics;
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
    public class CharacterMapperService : MapperBaseService<CharacterDto, Characters>, ICharacterService
    {
        readonly new ICharactersRepository _repository;
        public CharacterMapperService(ICharactersRepository repository, IMapper mapper, IValidator<CharacterDto> validator) : base(repository, mapper, validator)
        {
           
        }
    }
}
