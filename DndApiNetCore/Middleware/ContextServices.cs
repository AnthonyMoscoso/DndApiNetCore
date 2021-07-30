using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Models.Entities.EntityFW.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DndApiNetCore.Middleware
{
    public static class ContextServices
    {
        public static IServiceCollection GetContextRegisters(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DungeonsContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("ConnectionDbDungeons"), b => b.MigrationsAssembly("DndApiNetCore"));
            });
            return services;
        }
    }
}
