using System;
using System.Globalization;
using static DesignPatterns.Decorator.Bebida;

namespace DesignPatterns.Decorator
{
    public class ExecucaoDecorator
    {
        public static void Executar()
        {
			Console.Clear();
			Console.WriteLine("------------------------Cafeteria------------------------\n");

			Bebida bebida = new Expresso();
			Console.WriteLine(bebida.ObterDescricao()
					+ " = " + Math.Round(bebida.Preco(), 2).ToString("C", CultureInfo.CurrentCulture));

			Bebida bebida2 = new BemPassado();
			bebida2 = new Mocha(bebida2);
			bebida2 = new Mocha(bebida2);
			bebida2 = new Pingado(bebida2);
			Console.WriteLine(bebida2.ObterDescricao()
					+ " = " + Math.Round(bebida2.Preco(), 2).ToString("C", CultureInfo.CurrentCulture));

			Bebida bebida3 = new AModaDaCasa();
			bebida3.SalvarTamanho(Tamanho.Grande);
			bebida3 = new Soja(bebida3);
			bebida3 = new Mocha(bebida3);
			bebida3 = new Pingado(bebida3);
			Console.WriteLine(bebida3.ObterDescricao()
					+ " = " + Math.Round(bebida3.Preco(), 2).ToString("C", CultureInfo.CurrentCulture));

			Console.ReadKey();
			Console.Clear();
			Program.Main();
		}
    }
}
