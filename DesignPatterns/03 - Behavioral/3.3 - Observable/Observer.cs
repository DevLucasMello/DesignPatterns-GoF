namespace DesignPatterns.Observable
{
    public interface IObserver
    {
        public void Atualizar(double temperatura, double humidade, double pressao);
        public void Display();
    }
}