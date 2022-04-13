namespace DesignPatterns.AbstractFactory
{
	public class AzeitonasPretas : IVegetais
	{
		public string ConverterTexto()
		{
			return "Azeitonas Pretas";
		}
	}

	public class Beringela : IVegetais
	{
		public string ConverterTexto()
		{
			return "Beringela";
		}
	}

	public class AmendoasFrescas : IFrutosMar
	{
		public string ConverterTexto()
		{
			return "Amendoas Frescas da velha Ilha do Som";
		}
	}

	public class AmendoasCongeladas : IFrutosMar
	{
		public string ConverterTexto()
		{
			return "Amendoas congeladas da Baía de Chesapeake";
		}
	}

	public class Alho : IVegetais
	{
		public string ConverterTexto()
		{
			return "Alho";
		}
	}

	public class MolhoMarinara : IMolho
	{
		public string ConverterTexto()
		{
			return "Molho Marinara";
		}
	}

	public class QueijoMussarela : IQueijo
	{
		public string ConverterTexto()
		{
			return "Mussarela ralada";
		}
	}

	public class Cogumelo : IVegetais
	{
		public string ConverterTexto()
		{
			return "Cogumelos";
		}
	}

	public class Cebola : IVegetais
	{
		public string ConverterTexto()
		{
			return "Cebola";
		}
	}

	public class QueijoParmesao : IQueijo
	{
		public string ConverterTexto()
		{
			return "Parmesão ralado";
		}
	}

	public class MolhoTomateAmeixa : IMolho
	{
		public string ConverterTexto()
		{
			return "Molho de tomate com tomates ameixa";
		}
	}

	public class PimentaoVermelho : IVegetais
	{
		public string ConverterTexto()
		{
			return "Pimentao Vermelho";
		}
	}

	public class QueijoReggiano : IQueijo
	{
		public string ConverterTexto()
		{
			return "Queijo Reggiano";
		}
	}

	public class PeperoniFatiado : IPepperoni
	{
		public string ConverterTexto()
		{
			return "Peperoni Fatiado";
		}
	}

	public class Espinafre : IVegetais
	{
		public string ConverterTexto()
		{
			return "Espinafre";
		}
	}

	public class MassaGrossa : IMassa
	{
		public string ConverterTexto()
		{
			return "Massa estilo extra-grossa";
		}
	}

	public class MassaFina : IMassa
	{
		public string ConverterTexto()
		{
			return "Massa estilo fina";
		}
	}
}
