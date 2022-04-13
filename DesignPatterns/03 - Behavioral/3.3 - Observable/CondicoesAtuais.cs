using System;

namespace DesignPatterns.Observable
{
    public class CondicoesAtuais : IObserver
    {
        private double temperatura;
        private double humidade;
        private readonly Subject _subject;

        public CondicoesAtuais(Subject subject)
        {
            _subject = subject;
            _subject.RegistrarObservador(this);
        }

        public void Atualizar(double temperatura, double humidade, double pressao)
        {
            this.temperatura = temperatura;
            this.humidade = humidade;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Condições atuais: " + (int)temperatura
            + "°C e " + (int)humidade + "% humidade");
        }
    }
}