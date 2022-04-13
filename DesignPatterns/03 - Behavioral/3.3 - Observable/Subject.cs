using System.Collections.Generic;

namespace DesignPatterns.Observable
{

    public interface ISubject
    {
        public void RegistrarObservador(IObserver o);
        public void RemoverObservador(IObserver o);
        public void NotificarObservadores();
    }

    public class Subject : ISubject
    {
        private readonly List<IObserver> _observadores;
        private double temperatura;
        private double humidade;
        private double pressao;

        public Subject()
        {
            _observadores = new List<IObserver>();
        }

        public void RegistrarObservador(IObserver o)
        {
            _observadores.Add(o);
        }

        public void RemoverObservador(IObserver o)
        {
            _observadores.Remove(o);
        }

        public void NotificarObservadores()
        {
            foreach(var observador in _observadores)
            {
                observador.Atualizar(temperatura, humidade, pressao);
            }
        }

        public void MedicoesAlteradas()
        {
            NotificarObservadores();
        }

        public void DefinirMedicoes(double temperatura, double humidade, double pressao)
        {
            this.temperatura = temperatura;
            this.humidade = humidade;
            this.pressao = pressao;
            MedicoesAlteradas();
        }

        public double ObterTemperatura()
        {
            return temperatura;
        }

        public double ObterHumidade()
        {
            return humidade;
        }

        public double ObterPressao()
        {
            return pressao;
        }
    }
}
