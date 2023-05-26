using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrderProcessTracking.Application.Repositories;
using OrderProcessTracking.Persistence.Contexts;
using OrderProcessTracking.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessTracking.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPErsistenceService(this IServiceCollection services)
        {
            services.AddDbContext<dbContext>(options => options.UseNpgsql(Configuration.ConnectionString),ServiceLifetime.Scoped);
            services.AddScoped<ISellerReadRepository, SellerReadRepository>();
            services.AddScoped<ISellerWriteRepository, SellerWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
        }
    }
}
