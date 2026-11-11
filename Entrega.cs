using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeHerancaPolimorfismo
{
    public abstract class Entrega
    {
        public int Distancia { get; set; }
        
        protected decimal Frete { get; set; }

        public abstract void CalcularFrete(decimal frete, int taxaPorcentagem);
    }
}