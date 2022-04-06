namespace design_pattern_practice_in_csharp_singleton.Singleton._3_EarlyInitialization
{
    public class Settings
    {
        private Settings()
        {
        }

        public static Settings Instance { get; } = new();
    }
}
