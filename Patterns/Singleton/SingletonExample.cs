namespace DesignPatterns.Patterns.Singleton
{
    public class SingletonExample
    {
        private static SingletonExample singletonExample;
        private SingletonExample()
        {
        }

        public static SingletonExample GetInstace()
        {
            return singletonExample == null ? singletonExample = new SingletonExample() : singletonExample;
        }
    }
}
