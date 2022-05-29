namespace DesignPatterns.PatternsUtils
{
    #region Using Statements
    using DesignPatterns.Patterns.Builder;
    using DesignPatterns.Patterns.Singleton;
    #endregion
    public static class PatternFactory
    {

        #region Public Methods
        public static IComponentTest CreateDesignPattern(PatternType patternType)
        {
            IComponentTest component;

            switch(patternType)
            {
                case PatternType.SINGLETON:
                    component = new SingletonTest();
                    break;
                case PatternType.BUILDER:
                    component = new BuilderTest();
                    break;
                default:
                    throw new ArgumentException($"There is no implementation for {patternType}");
            }

            return component;
        }
        #endregion
    }
}
