namespace DesignPatterns.Patterns.Singleton.Singleton_Eager_Initialization_example
{
    public class Singleton_Eager
    {
        private static readonly Singleton_Eager instance = new Singleton_Eager();

        private Singleton_Eager()
        {
        }
        
        public static Singleton_Eager GetInstace()
        {
            return instance;
        }
    }
}