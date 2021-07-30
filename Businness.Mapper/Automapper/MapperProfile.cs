using AutoMapper;
using Models.Dto;
using Models.Entities.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businness.Mapper.Automapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
          {
            CreateMap<CharacterDto, Characters>().ReverseMap();
            CreateMap<JobDto, Job>().ReverseMap();
            CreateMap<RelationshipDto, RelationShip>().ReverseMap();
            CreateMap<RelationShipType, RelationShipTypeDto>().ReverseMap();
        }

    }
}
