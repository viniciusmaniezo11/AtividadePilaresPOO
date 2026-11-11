using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeHerancaPolimorfismo
{
    public class Ebook : ProdutoDigital
    {
        public int QuantidadePagina { get; set; }

        public Ebook(string nome, decimal valor, int qntPaginas) : base(nome, valor)
        {
            QuantidadePagina = qntPaginas;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome} - Preco {Preco:C} - Quantidade paginas {QuantidadePagina}");
        }
    }
}