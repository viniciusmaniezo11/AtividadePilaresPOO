using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeHerancaPolimorfismo
{
    public class EntregaEconomica : Entrega
    {
        public decimal Tarifa { get; set; }
        protected override decimal CalcularFrete()
        {
            return Frete - Tarifa;
        }

        public override void ExibirFrete()
        {
            Console.WriteLine($"O valor do frete é de {CalcularFrete():C}");
        }
    }
}