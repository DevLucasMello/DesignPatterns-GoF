using System;
using System.ComponentModel;

namespace DesignPatterns.FactoryMethod
{
    public class ExecucaoFactoryMethod
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
                    Console.Write("Deseja escolher outra viagem? S - Sim ou N - Não: ");
                    resposta = Console.ReadLine().ToUpper();
                }
            }

            Console.Clear();
            Program.Main();
        }

        private static void Programa()
        {
            Factory viagemFactory = null;

            Console.WriteLine("------------------------Agência de Viagens------------------------\n");            

            foreach (TipoViagem i in Enum.GetValues(typeof(TipoViagem)))
                Console.WriteLine(i.Descricao());

            Console.Write("\nEscolha um dos tipos de viagem acima: ");
            TipoViagem tipoViagem = (TipoViagem)Convert.ToInt32(Console.ReadLine());

            viagemFactory = (int)tipoViagem switch
            {
                1 => new ViagemCarroFactory(tipoViagem.Descricao()),
                2 => new ViagemAviaoFactory(tipoViagem.Descricao()),
                3 => new ViagemCaminhaoFactory(tipoViagem.Descricao()),
                _ => throw new ApplicationException("Não foi possível identificar o tipo da viagem"),
            };

            Console.WriteLine("\n\n--------------------------------------------------------------\n");

            ViagemAbstract viagem = viagemFactory.GerarViagem();
            viagem.IniciarViagem();
        }
    }

    public enum TipoViagem
    {
        [Description("1 - Viagem com carro")]
        Carro = 1,
        [Description("2 - Viagem com avião")]
        Aviao = 2,
        [Description("3 - Viagem com caminhão")]
        Caminhao = 3
    }

    public static class DescricaoEnum
    {
        public static string Descricao(this TipoViagem tv)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])tv
                .GetType().GetField(tv.ToString())
                .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
