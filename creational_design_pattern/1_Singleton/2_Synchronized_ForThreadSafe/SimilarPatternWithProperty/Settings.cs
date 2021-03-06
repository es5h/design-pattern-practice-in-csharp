namespace creational_design_pattern._1_Singleton._2_Synchronized_ForThreadSafe.SimilarPatternWithProperty
{
    public class Settings
    {
        private static Settings instance = null!;
        protected static readonly object Codelock = new ();
        
        Settings()
        {

        }

        public static Settings Instance
        {
            get
            {
                lock (Codelock)
                {
                    if (instance == null)
                    {
                        return new Settings();
                    }

                    return instance;
                }
            }
        }
    }
}