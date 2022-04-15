using System;
using System.Collections.Generic;

namespace DesignPatterns.Command
{
    public class ExecucaoCommand
    {
        public static void Executar()
        {
			Console.Clear();
			Console.WriteLine("------------------------Casa Inteligente------------------------\n");

			Programa();
        }

        private static void Programa()
        {
			ControleRemoto controleRemoto = new();

			Lampada lampada = new("Sala de Estar");
			TV tv = new("Sala de Estar");
			Som som = new("Sala de Estar");
			Banheira banheira = new();

			LampadaLigadaCommand lampadaLigada = new (lampada);
			SomLigadoCommand somLigado = new (som);
			TVLigadaCommand tvLigada = new (tv);
			BanheiraLigadaCommand banheiraLigada = new (banheira);
			LampadaDesligadaCommand lampadaDesligada = new (lampada);
			SomDesligadoCommand somDesligado = new (som);
			TVDesligadaCommand tvDesligada = new (tv);
			BanheiraDesligadaCommand banheiraDesligada = new (banheira);

			List<ICommand> festaLigada = new() { lampadaLigada, somLigado, tvLigada, banheiraLigada };
			List<ICommand> festaDesligada = new() { lampadaDesligada, somDesligado, tvDesligada, banheiraDesligada };

			MacroCommand festaLigadaMacro = new(festaLigada);
			MacroCommand festaDesligadaMacro = new(festaDesligada);

			controleRemoto.SalvarCommand(0, festaLigadaMacro, festaDesligadaMacro);

			Console.WriteLine(controleRemoto);
			Console.WriteLine("--- Macro Ativado ---");
			controleRemoto.BotaoLigarPressionado(0);
			
			Console.WriteLine($"\n{ controleRemoto }\n");
			Console.WriteLine("--- Macro Desativado ---");
            controleRemoto.BotaoDesligarPressionado(0);

			Console.WriteLine($"\n{ controleRemoto }\n");
			Console.WriteLine("--- Macro Desfazer ---");
			controleRemoto.BotaoDesfazerPressionado();

			Console.ReadKey();
			Console.Clear();
			Program.Main();
		}
    }
}
