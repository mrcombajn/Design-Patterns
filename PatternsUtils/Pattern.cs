using DesignPatterns.Patterns.Singleton;

namespace DesignPatterns.PatternsUtils
{
    public static class Pattern
    {

        public static IDesignPattern CreateDesignPatter(PatternType patternType)
        {
            return switch (patternType)
            {
                PatternType.SINGLETON => new SingletonTest(),
                _ => throw new ArgumentException("Cannot find appropriate design pattern")
            };

        }
    }
}
