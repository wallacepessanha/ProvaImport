using ExameImport.Business.Interfaces;
using ExameImport.Business.Services;
using ExameImport.Data.Context;
using ExameImport.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExameImport.Web.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ExameImportDbContext>();                         
            services.AddScoped<IStatementService, StatementService>();
            services.AddTransient<IStatementRepository, StatementRepository>();

            return services;
        }
    }
}
