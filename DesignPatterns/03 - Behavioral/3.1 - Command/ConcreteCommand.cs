using System.Collections.Generic;

namespace DesignPatterns.Command
{
    #region Ventilador
    public class VentiladorTetoMaximoCommand : ICommand
	{
        readonly VentiladorTeto _ventiladorTeto;
		int velocidadeAtual;

		public VentiladorTetoMaximoCommand(VentiladorTeto ventiladorTeto)
		{
			_ventiladorTeto = ventiladorTeto;
		}
		public void Executar()
		{
			velocidadeAtual = _ventiladorTeto.ObterVelocidade();
			_ventiladorTeto.Maximo();
		}
		public void Desfazer()
		{
			switch (velocidadeAtual)
			{
				case (int)VentiladorTeto.VelocidadesVentilador.Maximo: _ventiladorTeto.Maximo(); break;
				case (int)VentiladorTeto.VelocidadesVentilador.Medio: _ventiladorTeto.Medio(); break;
				case (int)VentiladorTeto.VelocidadesVentilador.Minimo: _ventiladorTeto.Minimo(); break;
				default: _ventiladorTeto.Desligar(); break;
			}
		}
	}

	public class VentiladorTetoMedioCommand : ICommand
	{
		readonly VentiladorTeto _ventiladorTeto;
		int velocidadeAtual;

		public VentiladorTetoMedioCommand(VentiladorTeto ventiladorTeto)
		{
			_ventiladorTeto = ventiladorTeto;
		}

		public void Executar()
		{
			velocidadeAtual = _ventiladorTeto.ObterVelocidade();
			_ventiladorTeto.Medio();
		}

		public void Desfazer()
		{
			switch (velocidadeAtual)
			{
				case (int)VentiladorTeto.VelocidadesVentilador.Maximo: _ventiladorTeto.Maximo(); break;
				case (int)VentiladorTeto.VelocidadesVentilador.Medio: _ventiladorTeto.Medio(); break;
				case (int)VentiladorTeto.VelocidadesVentilador.Minimo: _ventiladorTeto.Minimo(); break;
				default: _ventiladorTeto.Desligar(); break;
			}
		}
	}

	public class VentiladorTetoMinimoCommand : ICommand
	{
		readonly VentiladorTeto _ventiladorTeto;
		int velocidadeAtual;

		public VentiladorTetoMinimoCommand(VentiladorTeto ventiladorTeto)
		{
			_ventiladorTeto = ventiladorTeto;
		}

		public void Executar()
		{
			velocidadeAtual = _ventiladorTeto.ObterVelocidade();
			_ventiladorTeto.Minimo();
		}

		public void Desfazer()
		{
			switch (velocidadeAtual)
			{
				case (int)VentiladorTeto.VelocidadesVentilador.Maximo: _ventiladorTeto.Maximo(); break;
				case (int)VentiladorTeto.VelocidadesVentilador.Medio: _ventiladorTeto.Medio(); break;
				case (int)VentiladorTeto.VelocidadesVentilador.Minimo: _ventiladorTeto.Minimo(); break;
				default: _ventiladorTeto.Desligar(); break;
			}
		}
	}
	#endregion

	#region Banheira
	public class BanheiraDesligadaCommand : ICommand
	{
        readonly Banheira _banheira;

		public BanheiraDesligadaCommand(Banheira banheira)
		{
			_banheira = banheira;
		}

		public void Executar()
		{
			_banheira.SalvarTemperatura(37);
			_banheira.Desligar();
		}
		public void Desfazer()
		{
			_banheira.Ligar();
		}
	}

	public class BanheiraLigadaCommand : ICommand
	{
		readonly Banheira _banheira;

		public BanheiraLigadaCommand(Banheira banheira)
		{
			_banheira = banheira;
		}

		public void Executar()
		{
			_banheira.Ligar();
			_banheira.SalvarTemperatura(40);
			_banheira.Circular();
			_banheira.LigarJatos();
		}
		public void Desfazer()
		{
			_banheira.DesligarJatos();
			_banheira.Desligar();
		}
	}
	#endregion

	#region Lâmpada
	public class LampadaDesligadaCommand : ICommand
	{
        readonly Lampada _lampada;

		public LampadaDesligadaCommand(Lampada lampada)
		{
			_lampada = lampada;
		}

		public void Executar()
		{
			_lampada.Desligar();
		}

		public void Desfazer()
		{
			_lampada.Ligar();
		}
	}

	public class LampadaLigadaCommand : ICommand
	{
		readonly Lampada _lampada;

		public LampadaLigadaCommand(Lampada lampada)
		{
			_lampada = lampada;
		}

		public void Executar()
		{
			_lampada.Ligar();			
		}

		public void Desfazer()
		{
			_lampada.Desligar();
		}
	}

	public class LampadaDesligadaSalaEstarCommand : ICommand
	{
		readonly Lampada _lampada;

		public LampadaDesligadaSalaEstarCommand(Lampada lampada)
		{
			_lampada = lampada;
		}

		public void Executar()
		{
			_lampada.Desligar();
		}

		public void Desfazer()
		{
			_lampada.Ligar();
		}
	}

	public class LampadaLigadaSalaEstarCommand : ICommand
	{
		readonly Lampada _lampada;

		public LampadaLigadaSalaEstarCommand(Lampada lampada)
		{
			_lampada = lampada;
		}

		public void Executar()
		{
			_lampada.Ligar();
		}

		public void Desfazer()
		{
			_lampada.Desligar();
		}
	}
	#endregion

	#region Som
	public class SomDesligadoCommand : ICommand
	{
        readonly Som _som;


		public SomDesligadoCommand(Som som)
		{
			_som = som;
		}

		public void Executar()
		{
			_som.Desligar();
		}

		public void Desfazer()
		{
			_som.Ligar();
		}
	}

	public class SomLigadoCommand : ICommand
	{
		readonly Som _som;


		public SomLigadoCommand(Som som)
		{
			_som = som;
		}

		public void Executar()
		{
			_som.Ligar();
		}

		public void Desfazer()
		{
			_som.Desligar();
		}
	}

	public class SomLigadoComCDCommand : ICommand
	{
		readonly Som _som;


		public SomLigadoComCDCommand(Som som)
		{
			_som = som;
		}

		public void Executar()
		{
			_som.Ligar();
			_som.SalvarCD();
			_som.SalvarVolume(10);
		}

		public void Desfazer()
		{
			_som.Desligar();
		}
	}
	#endregion

	#region TV
	public class TVDesligadaCommand : ICommand
	{
        readonly TV _tv;

		public TVDesligadaCommand(TV tv)
		{
			_tv = tv;
		}

		public void Executar()
		{
			_tv.Desligar();
		}

		public void Desfazer()
		{
			_tv.Ligar();
		}
	}

	public class TVLigadaCommand : ICommand
	{
		readonly TV _tv;

		public TVLigadaCommand(TV tv)
		{
			_tv = tv;
		}

		public void Executar()
		{
			_tv.Ligar();
			_tv.DefinirSelecaoInicial();
		}

		public void Desfazer()
		{
			_tv.Desligar();
		}
	}
	#endregion

	public class NoCommand : ICommand
	{
		public void Executar() { }
		public void Desfazer() { }
	}

	public class MacroCommand : ICommand
	{
        readonly List<ICommand> _commands;


		public MacroCommand(List<ICommand> commands)
		{
			_commands = commands;
		}

		public void Executar()
		{
			for (int i = 0; i < _commands.Count; i++)
			{
				_commands[i].Executar();
			}
		}
		
		public void Desfazer()
		{
			for (int i = _commands.Count - 1; i >= 0; i--)
			{
				_commands[i].Desfazer();
			}
		}
	}

}