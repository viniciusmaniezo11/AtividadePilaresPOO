using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeHerancaPolimorfismo
{
    public class RetiradaLocal : Entrega
    {
        public RetiradaLocal(decimal distancia) : base(distancia)
        {
        }

        public override decimal CalcularFrete()
        {
            return 0m;
        }
    }
}