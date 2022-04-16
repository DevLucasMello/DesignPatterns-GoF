using System;

namespace DesignPatterns.Adapter
{
    public interface ITv
    {
        void TvInfo(string emissora);
        void TvException(Exception exception);
    }

    public class Tv : ITv
    {
        public void TvInfo(string emissora)
        {
            Console.WriteLine("Canal de exibição Padrão Y - " + emissora);
        }

        public void TvException(Exception exception)
        {
            Console.WriteLine("Canal de exibição Padrão Y - " + exception.Message);
        }
    }
}
