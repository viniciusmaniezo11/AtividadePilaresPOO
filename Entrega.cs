using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeHerancaPolimorfismo
{
    public abstract class Entrega
    {
        public int Distancia { get; set; }
        
        public decimal Frete { get; set; }

        protected abstract decimal CalcularFrete();

        public abstract void ExibirFrete();
    }
}