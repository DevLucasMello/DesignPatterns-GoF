using System;

namespace DesignPatterns.Strategy
{
    public class ExecucaoStrategy
    {
        public static void Executar()
        {
            var resposta = "";

            while (resposta != "N")
            {
                resposta = "";
                Console.Clear();
                Programa();

                while (resposta != "N" && resposta != "S")
                {
                    Console.Write("Deseja realizar a compra de mais um carro? S - Sim ou N - Não: ");
                    resposta = Console.ReadLine().ToUpper();
                }
            }

            Console.Clear();
            Program.Main();
        }

        private static void Programa()
        {
            Console.WriteLine("------------------------Loja de Carros------------------------\n");
            Console.Write("Digite o nome do carro: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o valor do carro: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            foreach (TipoCompra i in Enum.GetValues(typeof(TipoCompra)))
                Console.WriteLine(i.Descricao());

            Console.Write("\nEscolha uma das formas de pagamento acima: ");
            TipoCompra tipoCompra = (TipoCompra)Convert.ToInt32(Console.ReadLine());

            var compra = new CompraCarros(new Carro(nome, valor), tipoCompra);
            var desconto = compra.ValorDesconto();

            Console.WriteLine("\n\n--------------------------------------------------------------\n");
            Console.WriteLine("Compra realizada com sucesso!\n" +
                "\nParabéns por adquirir o {0}. Abaixo estão os dados de pagamento:\n\n" +
                "******************************************\n\n" +
                "Valor do carro: {1}\n" +
                "Valor do Desconto: {2}\n" +
                "Total Pago: {3}\n" +
                "Tipo de Pagamento: {4}\n\n" +
                "******************************************\n\n", nome, valor.ToString("C"), desconto.ToString("C"), (valor - desconto).ToString("C"), tipoCompra.Descricao().Remove(0, 3));
        }
    }    

    public class Carro
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public Carro(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
