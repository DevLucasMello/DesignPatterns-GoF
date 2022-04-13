using System;

namespace DesignPatterns.Observable
{
    public class ExecucaoObserver
    {
        public static void Executar()
        {
			Console.Clear();
			Console.WriteLine("------------------------Clima/Tempo------------------------\n");

			Subject subject = new Subject();

			var condicoesAtuais = new CondicoesAtuais(subject);
			var estatistica = new Estatistica(subject);
			var previsaoTempo = new PrevisaoTempo(subject);

			subject.DefinirMedicoes(27, 19, -1);
			subject.DefinirMedicoes(27, 21, -2);
			subject.DefinirMedicoes(25, 33, -2);

			subject.RemoverObservador(previsaoTempo);
			subject.DefinirMedicoes(17, 33, -3);

			Console.ReadKey();
			Console.Clear();
			Program.Main();
		}
    }
}
