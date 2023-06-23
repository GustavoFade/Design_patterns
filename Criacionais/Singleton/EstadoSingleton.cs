namespace DesingPatterns.Criacionais.Singleton
{
    public sealed class EstadoSingleton
    {
        private static EstadoSingleton _instance;
        private EstadoSingleton() {}

        public static EstadoSingleton GetIntance()
        {
            if (_instance is null)
            {
                System.Console.WriteLine("Nova instância de estado");
                _instance = new EstadoSingleton();
            }
            else
            {
                System.Console.WriteLine("Instância já existente");
            }
            return _instance;
        }

    }
}