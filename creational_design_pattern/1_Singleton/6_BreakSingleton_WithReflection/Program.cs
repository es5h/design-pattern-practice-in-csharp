namespace design_pattern_practice_in_csharp._1_Singleton._6_BreakSingleton_WithReflection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hi");
            /*Settings settings1 = Settings.GetInstance();

            Type type = typeof(Settings);
            IEnumerable<Type> types = AppDomain.CurrentDomain.GetAssemblies().ToList().SelectMany(s => s.GetTypes())
                .Where(type.IsAssignableFrom);
            Type type2 = types.FirstOrDefault(x => x.IsClass)!;
            Settings settings = Activator.CreateInstance(type2);
            
            Console.WriteLine(settings1 == settings2);*/
        }
    }
}