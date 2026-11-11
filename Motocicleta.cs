namespace AtividadeHerancaPolimorfismo
{
    public class Motocicleta : Veiculo
    {
        public int Cilindradas { get; set; }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca} - Modelo {Modelo} - Cilindradas {Cilindradas}");
        }
    }
}