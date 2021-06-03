using App.Domain.Interface;
using Microsoft.AspNetCore.Mvc;
using System;

namespace App.Controllers
{
    [Route("/")]
    [ApiController]
    public class AppController : ControllerBase
    {
        protected IDatabaseConfiguration database;
        protected IRedisConfiguration redis;
        public AppController(IDatabaseConfiguration database, IRedisConfiguration redis)
        {
            this.database = database;
            this.redis = redis;
        }

        [HttpPost]
        public IActionResult Post()
        {
            string assunto = Request.Form["assunto"];
            string mensagem = Request.Form["mensagem"];

            database.Insert(assunto, mensagem);
            Console.Out.WriteLine("Mensagem registrada no banco de dados.");

            redis.Push(assunto, mensagem);
            Console.Out.WriteLine("Mensagem registrada no cache (Redis).");

            return Ok($"Mensagem enfileirada. Title: {assunto} Body: {mensagem}");
        }
    }
}
