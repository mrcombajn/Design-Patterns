using DesignPatterns.PatternsUtils;

namespace DesignPatterns.Patterns.Strategy
{
    internal class StrategyTest : IComponentTest
    {
        public void Run()
        {

            Communication c = new Communication(new TextMessageStrategy());
            c.SetStrategy(new MailStrategy());
            c.InvokeStrategy();
        }
    }
}
