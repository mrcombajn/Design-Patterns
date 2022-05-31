namespace DesignPatterns.PatternsUtils
{
    #region Using Statements
    using DesignPatterns.Patterns.Builder;
    using DesignPatterns.Patterns.Singleton;
    using DesignPatterns.Patterns.Strategy;
    #endregion
    public static class ComponentFactory
    {

        #region Public Methods
        public static IComponentTest CreateComponent(ComponentType componentType)
        {
            switch (componentType)
            {
                case ComponentType.SINGLETON:
                    return new SingletonTest();
                case ComponentType.BUILDER:
                    return new BuilderTest();
                case ComponentType.STRATEGY:
                    return new StrategyTest();
                default:
                    throw new ArgumentException($"There is no implementation for {componentType}");
            }

        }
        #endregion
    }
}
