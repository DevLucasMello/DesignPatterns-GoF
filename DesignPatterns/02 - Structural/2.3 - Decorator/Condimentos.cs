namespace DesignPatterns.Decorator
{
    public abstract class CondimentosDecorator : Bebida 
    {
        public Bebida bebida;
        public Tamanho ObterTamanhoCondimento() => bebida.ObterTamanho();
    }

	public class Leite : CondimentosDecorator
	{
		public Leite(Bebida bebida)
		{
			this.bebida = bebida;
		}

		public override string ObterDescricao()
			=> $"{ bebida.ObterDescricao() } + { GetType().Name }";

		public override double Preco() => bebida.Preco() + .10;
	}

	public class Mocha : CondimentosDecorator
	{
		public Mocha(Bebida bebida)
		{
			this.bebida = bebida;
		}

		public override string ObterDescricao()
			=> $"{ bebida.ObterDescricao() } + { GetType().Name }";

		public override double Preco() => bebida.Preco() + .20;
	}

	public class Soja : CondimentosDecorator
	{
		public Soja(Bebida bebida)
		{
			this.bebida = bebida;
		}

		public override string ObterDescricao()
			=> $"{ bebida.ObterDescricao() } + { GetType().Name }";

		public override double Preco()
        {
			double preco = bebida.Preco();
			if (bebida.ObterTamanho() == Tamanho.Pequeno)
			{
				preco += .10;
			}
			else if (bebida.ObterTamanho() == Tamanho.Medio)
			{
				preco += .15;
			}
			else if (bebida.ObterTamanho() == Tamanho.Grande)
			{
				preco += .20;
			}
			return preco;
		}
	}

	public class Pingado : CondimentosDecorator
	{
		public Pingado(Bebida bebida)
		{
			this.bebida = bebida;
		}

		public override string ObterDescricao()
			=> $"{ bebida.ObterDescricao() } + { GetType().Name }";

		public override double Preco() => bebida.Preco() + .10;
	}
}
