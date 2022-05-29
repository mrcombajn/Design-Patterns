using DesignPatterns.PatternsUtils;

namespace DesignPatterns
{
    internal class Program
    {
        #region Using Statements

        #endregion

        static void Main(string[] args)
        {
            IComponentTest component = PatternFactory.CreateDesignPattern(PatternType.SINGLETON);
            component.Run();
            Console.WriteLine(component);
        }
    }
}