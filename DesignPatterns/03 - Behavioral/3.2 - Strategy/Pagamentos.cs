namespace DesignPatterns.Strategy
{
    public class PagamentoAVista : IDesconto
    {
        public decimal Desconto(Carro carro)
        {
            return carro.Valor * 15 / 100;
        }
    }

    public class PagamentoCartao : IDesconto
    {
        public decimal Desconto(Carro carro)
        {
            return carro.Valor * 10 / 100;
        }
    }

    public class PagamentoFinanciamento : IDesconto
    {
        public decimal Desconto(Carro carro)
        {
            return carro.Valor * 5 / 100;
        }
    }
}
