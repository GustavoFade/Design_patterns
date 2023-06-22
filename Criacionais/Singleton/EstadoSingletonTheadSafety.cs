namespace DesingPatterns.Criacionais.Singleton
{
    public sealed class EstadoSingletonTheadSafety
    {
        private static EstadoSingletonTheadSafety _instance;
        private static readonly object _lock = new object();

        private EstadoSingletonTheadSafety() {}

        public static EstadoSingletonTheadSafety GetIntance()
        {
            lock (_lock)
            {
                if (_instance is null)
                {
                    System.Console.WriteLine("Nova instância de estado");
                    _instance = new EstadoSingletonTheadSafety();
                }
                else
                {
                    System.Console.WriteLine("Instância já existente");
                }
            }
            
            return _instance;
        }
    }
}