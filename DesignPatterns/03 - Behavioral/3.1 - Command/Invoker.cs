using System.Text;

namespace DesignPatterns.Command
{
    public class ControleRemoto
    {
        readonly ICommand[] _ligarCommands;
        readonly ICommand[] _desligarCommands;
        ICommand _desfazerCommand;

		public ControleRemoto()
		{
			_ligarCommands = new ICommand[7];
			_desligarCommands = new ICommand[7];

			ICommand noCommand = new NoCommand();
			for (int i = 0; i < 7; i++)
			{
				_ligarCommands[i] = noCommand;
				_desligarCommands[i] = noCommand;
			}
			_desfazerCommand = noCommand;
		}

		public void SalvarCommand(int slot, ICommand ligarCommand, ICommand desligarCommand)
		{
			_ligarCommands[slot] = ligarCommand;
			_desligarCommands[slot] = desligarCommand;
		}

		public void BotaoLigarPressionado(int slot)
		{
			_ligarCommands[slot].Executar();
			_desfazerCommand = _ligarCommands[slot];
		}

		public void BotaoDesligarPressionado(int slot)
		{
			_desligarCommands[slot].Executar();
			_desfazerCommand = _desligarCommands[slot];
		}

		public void BotaoDesfazerPressionado()
		{
			_desfazerCommand.Desfazer();
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new();
			stringBuilder.Append("\n------ Controle Remoto -------\n");
			for (int i = 0; i < _ligarCommands.Length; i++)
			{
				stringBuilder.Append("[slot " + i + "] " + _ligarCommands[i].GetType().Name
					+ "    " + _desligarCommands[i].GetType().Name + "\n");
			}
			stringBuilder.Append("[Desfazer] " + _desfazerCommand.GetType().Name + "\n");
			return stringBuilder.ToString();
		}
	}
}