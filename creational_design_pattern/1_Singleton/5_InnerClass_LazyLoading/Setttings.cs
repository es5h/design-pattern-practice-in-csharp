namespace creational_design_pattern._1_Singleton._5_InnerClass_LazyLoading
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

        public static Settings Instance => SettingHolders.Instance;
    }
}