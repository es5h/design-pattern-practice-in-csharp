namespace design_pattern_practice_in_csharp_singleton._1_Singleton._3_EarlyInitialization
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Settings settings1 = Settings.Instance;
            Settings settings2 = Settings.Instance;

            Console.WriteLine(settings1 == settings2);
        }
    }
}
