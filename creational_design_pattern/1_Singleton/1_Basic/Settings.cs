namespace creational_design_pattern._1_Singleton._1_Basic
{
    internal class Settings
    {
        private static Settings instance = null!;

        private Settings()
        {
        }

        public static Settings Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Settings();
                }

                return instance;
            }
        }

    }
}
