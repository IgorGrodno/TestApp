using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Cards.Application.Interfaces;

namespace Cards.Persistance
{
    public static class DependesyIjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services,IConfiguration  configuration)
        {
            var connectionString = configuration["DBConnection"];
            services.AddDbContext<CardsBDContext>(options =>
            {
                options.UseSqlite(connectionString);
            });
            services.AddScoped<ICardsDBContext>(provider =>
            provider.GetService<CardsBDContext>());
            return services;  
        }
    }
}
