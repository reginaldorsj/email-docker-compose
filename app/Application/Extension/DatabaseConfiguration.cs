using App.Domain.Interface;
using App.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace App.Application.Extensions
{
    public static class DatabaseConfiguration
    {
        public static void AddDatabase(this IServiceCollection services)
        {
            services.AddSingleton<IDatabaseConfiguration, Database>();
        }
    }
}
