using System;

namespace DesignPatterns.Patterns.Singleton
{
    internal class Singleton_Lazy_SafeThreads
    {
        private static Singleton_Lazy_SafeThreads? instance;
        
        private static readonly object _lock = new object();
        
        private Singleton_Lazy_SafeThreads()
        {
        }

        public static Singleton_Lazy_SafeThreads GetInstace()
        {
            lock (_lock)
            {
                return instance ??= new Singleton_Lazy_SafeThreads();
            }
        }
    }
}