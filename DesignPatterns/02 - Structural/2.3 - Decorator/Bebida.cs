namespace DesignPatterns.Decorator
{
    public abstract class Bebida
    {
        public enum Tamanho { Pequeno, Medio, Grande };
        Tamanho tamanho = Tamanho.Pequeno;
        protected string descricao = "Bebida não encontrada";

		public virtual string ObterDescricao()
		{
			return descricao;
		}

		public void SalvarTamanho(Tamanho tamanho)
		{
			this.tamanho = tamanho;
		}

		public Tamanho ObterTamanho()
		{
			return tamanho;
		}

		public abstract double Preco();
	}

	public class BemPassado : Bebida
	{
		public BemPassado() => descricao = "Café Bem Passado";
		public override double Preco() => .99;		
	}

	public class Descafeinado : Bebida
	{
		public Descafeinado() => descricao = "Café Descafeinado";
		public override double Preco() => 1.05;		
	}

	public class Expresso : Bebida
	{
		public Expresso() => descricao = "Café Expresso";
		public override double Preco() => 1.99;
	}

	public class AModaDaCasa : Bebida
	{
		public AModaDaCasa() => descricao = "Café a Moda da Casa";
		public override double Preco() => .89;
	}

}
