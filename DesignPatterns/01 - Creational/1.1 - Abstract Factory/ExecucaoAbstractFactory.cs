using System;

namespace DesignPatterns.AbstractFactory
{
    public class ExecucaoAbstractFactory
    {
        public static void Executar()
        {
			Console.Clear();
			Console.WriteLine("------------------------Pizzaria------------------------\n");

			LojaPizzaFactory spLoja = new SPLojaPizza();
			LojaPizzaFactory rjLoja = new RJLojaPizza();

			Pizza pizza = spLoja.MontarPizza("queijo");
			Console.WriteLine("Lucas pediu uma " + pizza.GetType().Name + "\n");

			pizza = rjLoja.MontarPizza("queijo");
			Console.WriteLine("Jéssica pediu uma " + pizza.GetType().Name + "\n");

			pizza = spLoja.MontarPizza("frutosMar");
			Console.WriteLine("Lucas pediu uma " + pizza.GetType().Name + "\n");

			pizza = rjLoja.MontarPizza("frutosMar");
			Console.WriteLine("Jéssica pediu uma " + pizza.GetType().Name + "\n");

			pizza = spLoja.MontarPizza("pepperoni");
			Console.WriteLine("Lucas pediu uma " + pizza.GetType().Name + "\n");

			pizza = rjLoja.MontarPizza("pepperoni");
			Console.WriteLine("Jéssica pediu uma " + pizza.GetType().Name + "\n");

			pizza = spLoja.MontarPizza("vegetais");
			Console.WriteLine("Lucas pediu uma " + pizza.GetType().Name + "\n");

			pizza = rjLoja.MontarPizza("vegetais");
			Console.WriteLine("Jéssica pediu uma " + pizza.GetType().Name + "\n");

			Console.ReadKey();
			Console.Clear();
			Program.Main();
		}
    }
}
