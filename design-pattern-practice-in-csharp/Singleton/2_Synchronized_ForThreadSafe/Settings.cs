using System.Runtime.CompilerServices;

namespace design_pattern_practice_in_csharp_singleton.Singleton._2_Synchronized_ForThreadSafe
{
    internal class Settings
    {
        private static Settings _instance;

        private Settings()
        {
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
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
