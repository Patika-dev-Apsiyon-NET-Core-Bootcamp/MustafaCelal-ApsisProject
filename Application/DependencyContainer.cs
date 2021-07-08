using Application.Interfaces;
using Application.Services;
using Core.Interfaces;
using Core.Model;
using Data;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace App.Application
{
    public static class DependencyContainer
    {
        public static IServiceCollection RegisterApsis(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("Default")).UseLazyLoadingProxies());

            services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<AppDbContext>();


            services.AddScoped<IFlatService, FlatService>();
            services.AddScoped<IFlatRepository, FlatRepository>();

            
            
            services.AddAutoMapper(Assembly.GetExecutingAssembly());



            return services;
        }
    }
}
