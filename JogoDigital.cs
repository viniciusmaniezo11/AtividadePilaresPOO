using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeHerancaPolimorfismo
{
    public class JogoDigital : Jogo
    {
        public string? TipoMidia { get; set; }
        public int TamanhoGb { get; set; }  

        public JogoDigital(string nome, string plataforma, string tipoMidia, int tamanhoGb) : base(nome, plataforma)
        {
            TipoMidia = tipoMidia;
            TamanhoGb = tamanhoGb;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Nome do jogo: {Nome} - Plataforma: {Plataforma} - Midia: {TipoMidia} - Tamanho {TamanhoGb}Gb");
        }
    }
}