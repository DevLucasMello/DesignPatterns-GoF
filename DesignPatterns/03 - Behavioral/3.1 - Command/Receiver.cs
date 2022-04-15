using System;

namespace DesignPatterns.Command
{
    //CeilingFan
    public class VentiladorTeto
    {
		public enum VelocidadesVentilador
        {
			Desligado = 0,
			Minimo = 1,
			Medio = 2,
			Maximo = 3
        }		
		
        readonly string _ambiente;
		int velocidade;

		public VentiladorTeto(string ambiente)
		{
			_ambiente = ambiente;
		}

		public void Maximo()
		{
			velocidade = (int)VelocidadesVentilador.Maximo;
			Console.WriteLine(_ambiente + " ceiling fan is on high");
		}

		public void Medio()
		{
			velocidade = (int)VelocidadesVentilador.Medio;
			Console.WriteLine(_ambiente + " ceiling fan is on medium");
		}

		public void Minimo()
		{
			velocidade = (int)VelocidadesVentilador.Minimo;
			Console.WriteLine(_ambiente + " ceiling fan is on low");
		}

		public void Desligar()
		{
			velocidade = (int)VelocidadesVentilador.Desligado;
			Console.WriteLine(_ambiente + " ceiling fan is off");
		}

		public int ObterVelocidade()
		{
			return velocidade;
		}
	}

	//Hottub
	public class Banheira
	{
		bool ligado;
		int _temperatura;

		public Banheira() { }

		public void Ligar()
		{
			ligado = true;
		}

		public void Desligar()
		{
			ligado = false;
		}

		public void Circular()
		{
			if (ligado)
			{
				Console.WriteLine("A banheira de hidromassagem está borbulhando!");
			}
		}

		public void LigarJatos()
		{
			if (ligado)
			{
				Console.WriteLine("Os jatos de hidromassagem estão ligados");
			}
		}

		public void DesligarJatos()
		{
			if (ligado)
			{
				Console.WriteLine("Os jatos de hidromassagem estão desligados");
			}
		}

		public void SalvarTemperatura(int temperatura)
		{
			if (temperatura > _temperatura)
			{
				Console.WriteLine("A banheira está aquecendo até a temperatura de " + temperatura + "°C");
			}
			else
			{
				Console.WriteLine("A banheira está esfriando até a temperatura ambiente");
			}
			_temperatura = temperatura;
		}
	}

	//Light
	public class Lampada
	{
        readonly string _ambiente;
		int _nivel;

		public Lampada(string ambiente)
		{
			_ambiente = ambiente;
		}

		public void Ligar()
		{
			_nivel = 100;
			Console.WriteLine("Lâmpada está ligada");
		}

		public void Desligar()
		{
			_nivel = 0;
			Console.WriteLine("Lâmpada está desligada");
		}

		public void Escurecer(int nivel)
		{
			_nivel = nivel;
			if (nivel == 0)
			{
				Desligar();
			}
			else
			{
				Console.WriteLine("A luz está reduzida em " + nivel + "%");
			}
		}

		public int ObterNivel()
		{
			return _nivel;
		}
	}

	//Stereo
	public class Som
	{
		readonly string _ambiente;

		public Som(string ambiente)
		{
			_ambiente = ambiente;
		}

		public void Ligar()
		{
			Console.WriteLine(_ambiente + " som está ligado");
		}

		public void Desligar()
		{
			Console.WriteLine(_ambiente + " som está desligado");
		}

		public void SalvarCD()
		{
			Console.WriteLine(_ambiente + " som está definido para entrada de CD");
		}

		public void SalvarDVD()
		{
			Console.WriteLine(_ambiente + " som está definido para entrada de DVD");
		}

		public void SalvarRadio()
		{
			Console.WriteLine(_ambiente + " som está definido para entrada de Rádio");
		}

		public void SalvarVolume(int volume)
		{
			volume = volume < 0 ? 0 : volume;
			volume = volume > 11 ? 11 : volume;
			Console.WriteLine($"{ _ambiente } som está no volume { volume }");
		}
	}

	public class TV
	{
        readonly string _ambiente;
		int canal;

		public TV(string ambiente)
		{
			_ambiente = ambiente;
		}

		public void Ligar()
		{
			Console.WriteLine(_ambiente + " TV está ligada");
		}

		public void Desligar()
		{
			Console.WriteLine(_ambiente + " TV está desligada");
		}

		public void DefinirSelecaoInicial()
		{
			canal = 3;
			Console.WriteLine(_ambiente + " O canal de TV está definido para DVD");
		}
	}
}