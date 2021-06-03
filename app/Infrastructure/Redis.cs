using App.Domain.Interface;
using Newtonsoft.Json.Linq;
using ServiceStack.Redis;
using System;

namespace App.Infrastructure
{
    public class Redis : IRedisConfiguration
    {
        public void Push(string assunto, string mensagem)
        {
            string redis_host = Environment.GetEnvironmentVariable("REDIS_HOST") ?? "queue";
            RedisClient redisClient = new RedisClient(redis_host, 6379);
            JObject o = new JObject
                {
                    {"assunto", assunto},
                    {"mensagem", mensagem}
                };
            redisClient.RPush("sender", System.Text.Encoding.UTF8.GetBytes(o.ToString()));
        }
    }
}
