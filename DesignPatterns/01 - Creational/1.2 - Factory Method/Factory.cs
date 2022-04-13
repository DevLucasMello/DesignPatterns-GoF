namespace DesignPatterns.FactoryMethod
{
    public abstract class Factory
    {
        public string Veiculo { get; set; }
        public abstract ViagemAbstract GerarViagem();
    }

    public class ViagemAviaoFactory : Factory
    {
        public ViagemAviaoFactory(string tipoVeiculo)
        {
            Veiculo = tipoVeiculo;
        }

        public override ViagemAbstract GerarViagem()
        {
            return new ViagemAviao(Veiculo);
        }
    }

    public class ViagemCaminhaoFactory : Factory
    {
        public ViagemCaminhaoFactory(string tipoVeiculo)
        {
            Veiculo = tipoVeiculo;
        }

        public override ViagemAbstract GerarViagem()
        {
            return new ViagemCaminhao(Veiculo);
        }
    }

    public class ViagemCarroFactory : Factory
    {
        public ViagemCarroFactory(string tipoVeiculo)
        {
            Veiculo = tipoVeiculo;
        }

        public override ViagemAbstract GerarViagem()
        {
            return new ViagemCarro(Veiculo);
        }
    }    
}
