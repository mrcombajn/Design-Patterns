namespace DesignPatterns.Patterns.Singleton
{
    #region Using Statements
    using DesignPatterns.PatternsUtils;
    #endregion
    public class SingletonTest : IDesignPattern
    {
        #region Public Methods
        public void Run()
        {
            SingletonExample singletonExample = SingletonExample.GetInstace();
            //CheckSingletonToStringWithOneThread();
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// 
        /// </summary>
        private void CheckSingletonToStringWithOneThread()
        {
            for(int i = 0; i < 10; i++)
            {
                SingletonExample singletonExample = SingletonExample.GetInstace();
                Console.WriteLine(singletonExample);
            }
        }
        #endregion
    }
}
