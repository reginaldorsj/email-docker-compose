using App.Domain.Interface;
using App.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace App.Application.Extension
{
    public static class RedisConfiguration
    {
        public static void AddRedis(this IServiceCollection services)
        {
            services.AddSingleton<IRedisConfiguration, Redis>();
        }

    }
}
