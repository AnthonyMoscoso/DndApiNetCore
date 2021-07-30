using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businness.Mapper.Automapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMapper()
        {
            MapperConfiguration mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperProfile());
            });

            return mappingConfig;
        }

    }
}
