namespace DesignPatterns.Patterns.Singleton
{
    #region Using Statements
    using DesignPatterns.PatternsUtils;
    #endregion
    public class SingletonTest : IComponentTest
    {
        #region Public Methods
        public void Run()
        {
            Pope singletonExample = Pope.GetInstace("John Paul II");

            Console.WriteLine(singletonExample);
        }
        #endregion
    }
}
