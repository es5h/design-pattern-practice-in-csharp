namespace creational_design_pattern._1_Singleton._3_EarlyInitialization
{
    public class Settings
    {
        private Settings()
        {
        }

        public static Settings Instance { get; } = new();
    }
}
