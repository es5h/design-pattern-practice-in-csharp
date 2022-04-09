namespace design_pattern_practice_in_csharp._1_Singleton._2_Synchronized_ForThreadSafe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Settings settings1 = Settings.GetInstance();
            Settings settings2 = Settings.GetInstance();

            Console.WriteLine(settings1 == settings2);
        }
    }
}
