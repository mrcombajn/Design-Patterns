using DesignPatterns.Patterns.Singleton;

namespace DesignPatterns.PatternsUtils
{
    public static class Pattern
    {

        public static IDesignPattern CreateDesignPatter(PatternType patternType)
        {
            IDesignPattern designPattern;
            switch (patternType)
            {
                case PatternType.SINGLETON: 
                    designPattern = new SingletonTest();
                    break;
                default:
                    throw new ArgumentException("Cannot find appropriate design pattern");
            };

            return designPattern;
        }
    }
}
