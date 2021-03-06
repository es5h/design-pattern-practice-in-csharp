namespace creational_design_pattern._1_Singleton._6_BreakSingleton_WithReflection
{
    public class Settings
    {
        private Settings()
        {
        }

        private static class SettingHolders
        {
            public static readonly Settings Instance = new Settings();
        }

        public static Settings GetInstance()
        {
            return SettingHolders.Instance;
        }
    }
}