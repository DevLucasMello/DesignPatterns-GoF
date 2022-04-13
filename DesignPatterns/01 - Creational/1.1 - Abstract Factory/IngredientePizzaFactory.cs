using System.Collections.Generic;

namespace DesignPatterns.AbstractFactory
{
    public abstract class IngredientePizzaFactory
    {
		public abstract IMassa CriarMassa();
		public abstract IMolho CriarMolho();
		public abstract IQueijo CriarQueijo();
		public abstract List<IVegetais> CriarVegetais();
		public abstract IPepperoni CriarPepperoni();
		public abstract IFrutosMar CriarFrutosMar();
	}

	public class SPIngredientePizzaFactory : IngredientePizzaFactory
	{
		public override IMassa CriarMassa()
		{
			return new MassaFina();
		}

		public override IMolho CriarMolho()
		{
			return new MolhoMarinara();
		}

		public override IQueijo CriarQueijo()
		{
			return new QueijoReggiano();
		}

		public override List<IVegetais> CriarVegetais()
		{
			List<IVegetais> veggies = new() { new Alho(), new Cebola(), new Cogumelo(), new PimentaoVermelho() };
			return veggies;
		}

		public override IPepperoni CriarPepperoni()
		{
			return new PeperoniFatiado();
		}

		public override IFrutosMar CriarFrutosMar()
		{
			return new AmendoasFrescas();
		}
	}

	public class RJIngredientePizzaFactory : IngredientePizzaFactory
	{
		public override IMassa CriarMassa()
		{
			return new MassaGrossa();
		}

		public override IMolho CriarMolho()
		{
			return new MolhoTomateAmeixa();
		}

		public override IQueijo CriarQueijo()
		{
			return new QueijoMussarela();
		}

		public override List<IVegetais> CriarVegetais()
		{
			List<IVegetais> veggies = new() { new AzeitonasPretas(), new Espinafre(), new Beringela() };
			return veggies;
		}

		public override IPepperoni CriarPepperoni()
		{
			return new PeperoniFatiado();
		}

		public override IFrutosMar CriarFrutosMar()
		{
			return new AmendoasCongeladas();
		}
	}
}