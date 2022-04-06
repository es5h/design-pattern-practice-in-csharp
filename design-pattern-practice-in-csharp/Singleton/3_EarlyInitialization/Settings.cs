namespace design_pattern_practice_in_csharp_singleton.Singleton._3_EarlyInitialization
{
    public class Settings
    {
        private static readonly Settings Instance = new();

        private Settings()
        {
        }

        public static Settings GetInstance()
        {
            return Instance;
        }
    }
}
