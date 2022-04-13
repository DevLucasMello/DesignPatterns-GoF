using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
	public abstract class Pizza
	{
		public string nome;
		public string processoPreparar = "Ingredientes";

		public IMassa massa;
		public IMolho molho;
		public List<IVegetais> vegetais;
		public IQueijo queijo;
		public IPepperoni pepperoni;
		public IFrutosMar frutosMar;

		public abstract void Preparar();

		public void Assar()
		{
			Console.WriteLine("Asse de 25 a 30 minutos");
		}

		public void Cortar()
		{
			Console.WriteLine("Corte a pizza em fatias diagonais");
		}

		public void Encaixotar()
		{
			Console.WriteLine("Coloque a pizza na caixa oficial da LojaPizza");
		}

		public void SalvarNome(string nome)
		{
			this.nome = nome;
		}

		public string ObterNome()
		{
			return nome;
		}

		public string ConverterTexto()
		{
			StringBuilder result = new();
			result.Append("---- " + processoPreparar + " ----\n");
			if (massa != null)
			{
				result.Append(massa.GetType().Name);
				result.Append('\n');
			}
			if (molho != null)
			{
				result.Append(molho.GetType().Name);
				result.Append('\n');
			}
			if (queijo != null)
			{
				result.Append(queijo.GetType().Name);
				result.Append('\n');
			}
			if (vegetais != null)
			{
				for (int i = 0; i < vegetais.Count; i++)
				{
					result.Append(vegetais[i].GetType().Name);
					if (i < vegetais.Count - 1)
					{
						result.Append(", ");
					}
				}
				result.Append('\n');
			}
			if (frutosMar != null)
			{
				result.Append(frutosMar.GetType().Name);
				result.Append('\n');
			}
			if (pepperoni != null)
			{
				result.Append(pepperoni.GetType().Name);
				result.Append('\n');
			}
			return result.ToString();
		}
	}

	public class PizzaQueijo : Pizza
	{
        readonly IngredientePizzaFactory _ingredienteFactory;


		public PizzaQueijo(IngredientePizzaFactory ingredienteFactory)
		{
			_ingredienteFactory = ingredienteFactory;
		}

        public override void Preparar()
        {			
			massa = _ingredienteFactory.CriarMassa();
			molho = _ingredienteFactory.CriarMolho();
			queijo = _ingredienteFactory.CriarQueijo();
			Console.WriteLine(ConverterTexto());
		}
	}

	public class PizzaFrutosMar : Pizza
	{
        readonly IngredientePizzaFactory _ingredienteFactory;


		public PizzaFrutosMar(IngredientePizzaFactory ingredienteFactory)
		{
			_ingredienteFactory = ingredienteFactory;
		}

		public override void Preparar()
		{			
			massa = _ingredienteFactory.CriarMassa();
			molho = _ingredienteFactory.CriarMolho();
			queijo = _ingredienteFactory.CriarQueijo();
			frutosMar = _ingredienteFactory.CriarFrutosMar();
			Console.WriteLine(ConverterTexto());
		}
	}

	public class PizzaPepperoni : Pizza
	{
        readonly IngredientePizzaFactory _ingredienteFactory;


		public PizzaPepperoni(IngredientePizzaFactory ingredienteFactory)
		{
			_ingredienteFactory = ingredienteFactory;
		}

		public override void Preparar()
		{			
			massa = _ingredienteFactory.CriarMassa();
			molho = _ingredienteFactory.CriarMolho();
			queijo = _ingredienteFactory.CriarQueijo();
            vegetais = _ingredienteFactory.CriarVegetais();
            pepperoni = _ingredienteFactory.CriarPepperoni();
			Console.WriteLine(ConverterTexto());
		}
	}

	public class PizzaVegetais : Pizza
	{
        readonly IngredientePizzaFactory _ingredienteFactory;


		public PizzaVegetais(IngredientePizzaFactory ingredienteFactory)
		{
			_ingredienteFactory = ingredienteFactory;
		}

		public override void Preparar()
		{			
			massa = _ingredienteFactory.CriarMassa();
			molho = _ingredienteFactory.CriarMolho();
			queijo = _ingredienteFactory.CriarQueijo();
			vegetais = _ingredienteFactory.CriarVegetais();
			Console.WriteLine(ConverterTexto());
		}
	}
}