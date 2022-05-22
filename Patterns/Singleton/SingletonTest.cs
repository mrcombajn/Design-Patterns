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
            //Pope singletonExample = Pope.GetInstace();
            //CheckSingletonToStringWithOneThread();
            //CheckSingletonToStringWithManyThreads();
            //CheckSafeSingletonWithManyThreads()
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
                Pope singletonExample = Pope.GetInstace();
                Console.WriteLine(singletonExample);
            }
        }

        private void CheckSingletonToStringWithManyThreads()
        {
            Thread th1 = new Thread(() =>
            {
                Console.WriteLine(Pope.GetInstace());
            });
            Thread th2 = new Thread(() =>
            {
                Console.WriteLine(Pope.GetInstace());
            });

            th1.Start();
            th2.Start();

            th1.Join();
            th2.Join();
        }

        private void CheckSafeSingletonWithManyThreads()
        {
            Thread th1 = new Thread(() =>
            {
                Console.WriteLine(PopeSafeThreads.GetInstace());
            });
            Thread th2 = new Thread(() =>
            {
                Console.WriteLine(PopeSafeThreads.GetInstace());
            });

            th1.Start();
            th2.Start();

            th1.Join();
            th2.Join();
        }
        #endregion
    }
}
