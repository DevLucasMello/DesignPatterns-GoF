using System;

namespace DesignPatterns.Facade
{
    public interface IAcademia
    {
        void ComprarSuplemento();
        void FazerAula();
    }

    public class Academia : IAcademia
    {
        public void ComprarSuplemento()
        {
            Console.WriteLine("Comprar Whey");
        }

        public void FazerAula()
        {
            Console.WriteLine("Fazer Musculação");
        }
    }

    public interface ILoja
    {
        void ComprarBola();
        void ComprarUniforme();
    }

    public class Loja : ILoja
    {
        public void ComprarBola()
        {
            Console.WriteLine("Comprar bola de futebol");
        }

        public void ComprarUniforme()
        {
            Console.WriteLine("Comprar uniforme do Corinthians");
        }
    }
}
