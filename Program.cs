using DesignPatterns.Patterns.Singleton;

namespace DesignPatterns // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        #region Using Statements

        #endregion

        static void Main(string[] args)
        {
            SingletonTest singleton = new SingletonTest();
            singleton.Run();
        }
    }
}