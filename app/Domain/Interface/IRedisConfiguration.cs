using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Domain.Interface
{
    public interface IRedisConfiguration
    {
        void Push(string assunto, string mensagem);
    }
}
