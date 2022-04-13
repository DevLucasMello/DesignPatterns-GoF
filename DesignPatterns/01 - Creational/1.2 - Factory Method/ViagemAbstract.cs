using System;

namespace DesignPatterns.FactoryMethod
{
    public abstract class ViagemAbstract
    {
        public string TipoVeiculo { get; set; }

        public abstract void IniciarViagem();
    }

    public class ViagemAviao : ViagemAbstract
    {
        public ViagemAviao(string tipoVeiculo)
        {
            TipoVeiculo = tipoVeiculo;
        }

        public override void IniciarViagem()
        {
            Console.WriteLine("Viagem com Avião");
        }
    }

    public class ViagemCaminhao : ViagemAbstract
    {
        public ViagemCaminhao(string tipoVeiculo)
        {
            TipoVeiculo = tipoVeiculo;
        }

        public override void IniciarViagem()
        {
            Console.WriteLine("Viagem com Caminhão");
        }
    }

    public class ViagemCarro : ViagemAbstract
    {
        public ViagemCarro(string tipoVeiculo)
        {
            TipoVeiculo = tipoVeiculo;
        }

        public override void IniciarViagem()
        {
            Console.WriteLine("Viagem com Carro");
        }
    }
}
