using DesignPatterns.PatternsUtils;

namespace DesignPatterns
{
    internal class Program
    {
        #region Using Statements

        #endregion

        static void Main(string[] args)
        {
            IComponentTest component = ComponentFactory.CreateComponent(ComponentType.STRATEGY);
            component.Run();
        }
    }
}