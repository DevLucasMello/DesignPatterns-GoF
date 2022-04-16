using System;

namespace DesignPatterns.Adapter
{
    public class TvAdapter : ITv
    {
        private readonly ITvCustomizado _tvCustomizado;

        public TvAdapter(ITvCustomizado tvCustomizado)
        {
            _tvCustomizado = tvCustomizado;
        }

        public void TvInfo(string emissora)
        {
            _tvCustomizado.TvCustomInfo(emissora);
        }

        public void TvException(Exception exception)
        {
            _tvCustomizado.TvCustomException(exception);
        }
    }

    public class TvService
    {
        private readonly ITv _tv;

        public TvService(ITv tv)
        {
            _tv = tv;
        }

        public void MostrarCanais()
        {
            _tv.TvInfo("Emissora");
        }
    }
}
