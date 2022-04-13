using System;
using System.ComponentModel;

namespace DesignPatterns.Strategy
{
    public class CompraCarros
    {
        private readonly Carro _carro;
        private readonly int _tipoCompra;
        private readonly IDesconto _desconto;

        public CompraCarros(Carro carro, TipoCompra tipoCompra)
        {
            _carro = carro;
            _tipoCompra = (int)tipoCompra;
            _desconto = TipoDesconto(_tipoCompra);
        }

        public decimal ValorDesconto()
        {
            var valorDesconto = _desconto.Desconto(_carro);
            return valorDesconto;
        }

        public IDesconto TipoDesconto(int tipoCompra)
        {
            switch (tipoCompra)
            {
                case 1: return new PagamentoAVista();
                case 2: return new PagamentoCartao();
                case 3: return new PagamentoFinanciamento();
                default: throw new ApplicationException("Não foi possível identificar a forma de pagamento");
            }

        }
    }

    public enum TipoCompra
    {
        [Description("1 - Pagamento à vista")]
        AVista = 1,
        [Description("2 - Pagamento com cartão de crédito")]
        Cartao = 2,
        [Description("3 - Pagamento financiado")]
        Financioamento = 3
    }

    public static class DescricaoEnum
    {
        public static string Descricao(this TipoCompra tp)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])tp
                .GetType().GetField(tp.ToString())
                .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
