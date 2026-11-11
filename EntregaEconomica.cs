using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeHerancaPolimorfismo
{
    public class EntregaEconomica : Entrega
    {
        public override void CalcularFrete(decimal frete, int tarifa)
        {
            Frete = frete - tarifa;
            Console.WriteLine($"Tipo de entrega: Economica - Valor do frete {Frete:C}");
        }
    }
}