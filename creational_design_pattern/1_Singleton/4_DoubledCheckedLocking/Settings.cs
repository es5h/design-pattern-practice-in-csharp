namespace creational_design_pattern._1_Singleton._4_DoubledCheckedLocking
{
    public class Settings
    {
        private static volatile Settings _instance;
        private static readonly object Lock = new();

        private Settings()
        {
        }

        public static Settings GetInstance()
        {
            if (_instance == null)
            {
                lock(Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Settings();
                    }
                }
            }
            
            return _instance;   
        }
    }
}
