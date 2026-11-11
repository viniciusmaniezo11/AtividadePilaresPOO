using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeHerancaPolimorfismo
{
    public class Carro : Veiculo
    {
        public int QuantidadePortas { get; set; }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca} - Modelo {Modelo} - Quantidade de portas {QuantidadePortas}");
        }
        
    }
}