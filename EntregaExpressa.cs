namespace AtividadeHerancaPolimorfismo
{
    public class EntregaExpressa : Entrega
    {
        public EntregaExpressa(decimal distancia) : base(distancia)
        {
        }

        public decimal TaxaAdicional { get; set; } = 15m;
        public override decimal CalcularFrete()
        {
            return (Distancia * 2) + (Distancia / 100 * TaxaAdicional);
        }
    }
}