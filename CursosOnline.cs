using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeHerancaPolimorfismo
{
    public class CursosOnline : ProdutoDigital
    {
        public int CargaHoraria { get; set; }

        public CursosOnline(string nome, decimal valor, int cargaHoraria) : base(nome, valor)
        {
            CargaHoraria = cargaHoraria;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome} - Preco {Preco:C} - Carga horaria {CargaHoraria}");
        }
    }
}