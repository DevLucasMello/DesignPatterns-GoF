namespace DesignPatterns.Singleton
{
    public sealed class Singleton
    {
        private static readonly Singleton _unicaInstancia = new Singleton();

		private Singleton() { }

		public static Singleton ObterInstancia()
		{			
			return _unicaInstancia;
		}

		// Outros métodos e comportamentos da classe
		public string ObterDescricao()
		{
			return "Eu sou uma instância segura de Singleton!";
		}
	}
}
