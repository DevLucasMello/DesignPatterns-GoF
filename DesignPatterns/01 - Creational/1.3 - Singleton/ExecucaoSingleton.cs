using System;

namespace DesignPatterns.Singleton
{
    public class ExecucaoSingleton
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("------------------------Instância de Singleton------------------------\n");

            var instancia1 = Singleton.ObterInstancia();
            var instancia2 = Singleton.ObterInstancia();
            var instancia3 = Singleton.ObterInstancia();
            var instancia4 = Singleton.ObterInstancia();

            if (instancia1.Equals(instancia2) && instancia2.Equals(instancia3)
                && instancia3.Equals(instancia4))
            {
                Console.WriteLine("Mesma instância.\n");
            }

            Singleton singleton = Singleton.ObterInstancia();
            Console.WriteLine(singleton.ObterDescricao());

            Console.ReadKey();
            Console.Clear();
            Program.Main();
        }
    }
}
