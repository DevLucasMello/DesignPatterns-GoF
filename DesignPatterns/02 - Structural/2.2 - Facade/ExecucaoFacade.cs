using System;

namespace DesignPatterns.Facade
{
    class ExecucaoFacade
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("------------------------Academia Dev------------------------\n");

            Programa();

            Console.ReadKey();
            Console.Clear();
            Program.Main();
        }

        public static void Programa()
        {
            var facade = LucasSportsFacade.InstanciaClient();

            Console.WriteLine("*******COMPRAS LOJA DE ARTIGOS ESPORTIVOS*******\n");
            facade.ItensLoja();

            Console.WriteLine("\n****************COMPRAS ACADEMIA****************\n");
            facade.ItensAcademia();
        }
    }
}
