using System;

namespace DesignPatterns.Observable
{
    public class Estatistica : IObserver
    {
        private double maxTemp = 0;
        private double minTemp = 93;
        private double somaTemp = 0;
        private int numLeituras = 0;
        private readonly Subject _subject;

        public Estatistica(Subject subject)
        {
            _subject = subject;
            _subject.RegistrarObservador(this);
        }

        public void Atualizar(double temperatura, double humidade, double pressao)
        {
            somaTemp += temperatura;
            numLeituras++;

            if (temperatura > maxTemp)
            {
                maxTemp = temperatura;
            }

            if (temperatura < minTemp)
            {
                minTemp = temperatura;
            }

            Display();
        }

        public void Display()
        {
            Console.WriteLine("Estatística - Média/Máxima/Mínima temperatura : " + (int)(somaTemp / numLeituras)
                + "/" + (int)maxTemp + "/" + (int)minTemp);
        }
    }
}