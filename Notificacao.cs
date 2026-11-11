using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeHerancaPolimorfismo
{
    public class Notificacao
    {
        public virtual void Enviar()
        {
            Console.WriteLine("Você recebeu uma nova mensagem.");
        }
    }
}