namespace AtividadeHerancaPolimorfismo
{
    public abstract class Entrega
    {
        public decimal Distancia { get; set; }
        
        protected decimal Frete { get; set; }

        public abstract decimal CalcularFrete();

        public Entrega(decimal distancia)
        {
            Distancia = distancia;
        }
    }
}