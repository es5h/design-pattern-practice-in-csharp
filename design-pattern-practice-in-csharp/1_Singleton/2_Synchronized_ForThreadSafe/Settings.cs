using System.Runtime.CompilerServices;

namespace design_pattern_practice_in_csharp_singleton._1_Singleton._2_Synchronized_ForThreadSafe
{
    internal class Settings
    {
        private static Settings instance;

        private Settings()
        {
        }

        
        // 해당 attribute 가 생성자 메서드에서만 사용가능해 Property 사용하는 법에 대한 고민 필요
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Settings GetInstance()
        {
            if (instance == null)
            {
                instance = new Settings();
            }

            return instance;
        }

    }
}
