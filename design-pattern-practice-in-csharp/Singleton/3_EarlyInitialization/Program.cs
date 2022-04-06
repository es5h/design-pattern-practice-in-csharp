namespace design_pattern_practice_in_csharp_singleton.Singleton._3_EarlyInitialization
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
