using DesignPatterns.PatternsUtils;

namespace DesignPatterns.Patterns.Strategy
{
    internal class StrategyTest : IComponentTest
    {
        public void Run()
        {

            Communication c = new Communication();
            c.SetStrategy(new Mail());
            c.InvokeStrategy();
        }
    }
}
