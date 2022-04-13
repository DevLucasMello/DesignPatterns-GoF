using System;

namespace DesignPatterns.Observable
{
    public class PrevisaoTempo : IObserver
    {
        private double pressaoAtual = -1;
        private double ultimaPressao;
        private readonly Subject _subject;

        public PrevisaoTempo(Subject subject)
        {
            _subject = subject;
            _subject.RegistrarObservador(this);
        }

        public void Atualizar(double temperatura, double humidade, double pressao)
        {
            ultimaPressao = pressaoAtual;
            pressaoAtual = pressao;
            Display();
        }

        public void Display()
        {
            Console.Write("Previsão do tempo: ");
            if (pressaoAtual > ultimaPressao)
            {
                Console.WriteLine("O clima ficará ensolarado!\n");
            }
            else if (pressaoAtual == ultimaPressao)
            {
                Console.WriteLine("O clima continuará ensolarado\n");
            }
            else if (pressaoAtual < ultimaPressao)
            {
                Console.WriteLine("O clima ficará frio e chuvoso\n");
            }
        }
    }
}