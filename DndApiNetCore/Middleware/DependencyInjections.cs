using Businness.Services.Abstracts;
using Businness.Services.Specifics.Mapper;
using Businness.Validations;
using FluentValidation;
using Infra.DataAcces.Abstracts;
using Infra.DataAcces.Specifics.DataBases.EF;
using Microsoft.Extensions.DependencyInjection;
using Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DndApiNetCore.Middleware
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddDependencyResolver( this IServiceCollection services)
        {
            // Characters
            services.AddScoped<ICharactersRepository, CharactersEFRepository>();
            services.AddScoped<ICharacterService, CharacterMapperService>();
            services.AddScoped<IValidator<CharacterDto>, CharacterValidator>();


            // Job
            services.AddScoped<IJobRepository, JobEFRepository>();
            services.AddScoped<IJobService, JobMapperService>();
            services.AddScoped<IValidator<JobDto>, JobValidator>();


            return services;
        }
    }
}
