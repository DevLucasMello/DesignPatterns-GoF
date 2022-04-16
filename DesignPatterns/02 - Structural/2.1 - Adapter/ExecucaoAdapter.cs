using System;

namespace DesignPatterns.Adapter
{
    public class ExecucaoAdapter
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("------------------------Programação da TV------------------------\n");

            Programa();

            Console.ReadKey();
            Console.Clear();
            Program.Main();
        }

        public static void Programa()
        {
            var tv = new TvService(new Tv());
            tv.MostrarCanais();

            var tvCustomizado = new TvService(new TvAdapter(new TvCustomizado()));
            tvCustomizado.MostrarCanais();
        }
    }
}
