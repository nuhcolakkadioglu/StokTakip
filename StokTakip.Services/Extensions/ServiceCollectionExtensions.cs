using Microsoft.Extensions.DependencyInjection;
using StokTakip.Data.Abstract;
using StokTakip.Data.Concrete;
using StokTakip.Services.Abstract;
using StokTakip.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyService(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IBirimService, BirimManager>();

            return services;
        }
    }
}
