using DataAccess.Context;
using DataAccess.Repositories;
using Domain.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<NorthwindContext>(opt => opt.UseSqlServer(config.GetConnectionString("NorthwindDatabase")));

            services.AddScoped<ICustomer, CustomerRepository>();

            return services;
        }
    }
}
