namespace DesingPatterns.Estruturais.Adapter
{
    public class Adapter
    {
        public interface ILogger
        {
            string EnviarLog();
        }

        public class Log
        {
            public string LogEspecifico()
            {
                return "Log especifico !";
            }
        }

        public class Adapter : ILogger
        {
            private readonly Log _log;

            public Adapter(Log adaptee)
            {
                this._log = adaptee;
            }

            public string EnviarLog()
            {
                return this._log.LogEspecifico();
            }
        }

    }
}
