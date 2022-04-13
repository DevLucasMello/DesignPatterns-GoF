using System;

namespace DesignPatterns.AbstractFactory
{
    public abstract class LojaPizzaFactory
	{
		protected abstract Pizza FazerPizza(string item);

		public Pizza MontarPizza(string type)
		{
			Pizza pizza = FazerPizza(type);
			Console.WriteLine("*** Preparando a " + pizza.ObterNome() + " ***");
			pizza.Preparar();
			pizza.Assar();
			pizza.Cortar();
			pizza.Encaixotar();
			return pizza;
		}
	}

	public class SPLojaPizza : LojaPizzaFactory
	{
		protected override Pizza FazerPizza(string item)
		{
			Pizza pizza = null;
			IngredientePizzaFactory ingredienteFactory = new SPIngredientePizzaFactory();

			if (item.Equals("queijo"))
			{
				pizza = new PizzaQueijo(ingredienteFactory);
				pizza.SalvarNome("Pizza de Queijo no estilo SP");
			}
			else if (item.Equals("vegetais"))
			{
				pizza = new PizzaVegetais(ingredienteFactory);
				pizza.SalvarNome("Pizza de Vegetais no estilo SP");
			}
			else if (item.Equals("frutosMar"))
			{
				pizza = new PizzaFrutosMar(ingredienteFactory);
				pizza.SalvarNome("Pizza de Frutos do Mar no estilo SP");
			}
			else if (item.Equals("pepperoni"))
			{
				pizza = new PizzaPepperoni(ingredienteFactory);
				pizza.SalvarNome("Pizza de Pepperoni no estilo SP");
			}
			return pizza;
		}
	}

	public class RJLojaPizza : LojaPizzaFactory
	{
		protected override Pizza FazerPizza(string item)
		{
			Pizza pizza = null;
			IngredientePizzaFactory ingredienteFactory = new RJIngredientePizzaFactory();

			if (item.Equals("queijo"))
			{
				pizza = new PizzaQueijo(ingredienteFactory);
				pizza.SalvarNome("Pizza de Queijo no estilo RJ");
			}
			else if (item.Equals("vegetais"))
			{
				pizza = new PizzaVegetais(ingredienteFactory);
				pizza.SalvarNome("Pizza de Vegetais no estilo RJ");
			}
			else if (item.Equals("frutosMar"))
			{
				pizza = new PizzaFrutosMar(ingredienteFactory);
				pizza.SalvarNome("Pizza de Frutos do Mar no estilo RJ");
			}
			else if (item.Equals("pepperoni"))
			{
				pizza = new PizzaPepperoni(ingredienteFactory);
				pizza.SalvarNome("Pizza de Pepperoni no estilo RJ");
			}
			return pizza;
		}
	}
}
