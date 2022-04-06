namespace design_pattern_practice_in_csharp_singleton.Singleton._1_Basic
{
    internal class Settings
    {
        private static Settings _instance;

        private Settings()
        {
        }

        public static Settings GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Settings();
            }

            return _instance;
        }

    }
}
