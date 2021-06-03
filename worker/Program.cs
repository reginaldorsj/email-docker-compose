using Newtonsoft.Json.Linq;
using ServiceStack.Redis;
using System;
using System.Threading;

namespace Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            string redis_host = Environment.GetEnvironmentVariable("REDIS_HOST") ?? "queue";
            RedisClient redisClient = new RedisClient(redis_host, 6379);

            Console.Out.WriteLine("Aguardando mensagem...");

            while (true)
            {
                byte[] mensagem = redisClient.BLPop("sender", 0)[1];
                string result = System.Text.Encoding.UTF8.GetString(mensagem);
                JObject j = JObject.Parse(result);

                Console.Out.WriteLine("Mandando mensagem...");

                //Simultion for sending email
                Console.Out.WriteLine($"Assunto: {j.GetValue("assunto")} | Mensagem: {j.GetValue("mensagem")}");
                Thread.Sleep(new Random().Next(0, 20000));

                Console.Out.WriteLine("Mensagem envidada!");
            }
        }
    }
}
