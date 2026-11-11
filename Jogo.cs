using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeHerancaPolimorfismo
{
    public abstract class Jogo
    {
        public string? Nome { get; set; }

        protected string? Plataforma;

        public abstract void ExibirInformacoes();

        public Jogo(string nome, string plataforma)
        {
            Nome = nome;
            Plataforma = plataforma;
        }
    }
}