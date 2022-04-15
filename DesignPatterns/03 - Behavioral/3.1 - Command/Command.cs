namespace DesignPatterns.Command
{
    public interface ICommand
	{
		public void Executar();
		public void Desfazer();
	}

}
