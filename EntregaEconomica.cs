using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeHerancaPolimorfismo
{
    public class EntregaEconomica : Entrega
    {
        public EntregaEconomica(decimal distancia) : base(distancia)
        {
        }

        public decimal Tarifa { get; set; } = 20m; 
        public override decimal CalcularFrete()
        {
            return Distancia * 2 - Tarifa;
        }
    }
}