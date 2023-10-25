using System;

namespace DesignPatterns.Patterns.Strategy
{
    public class CallStrategy : CommunicationStrategy
    {
        public void Communicate()
        {
            Console.WriteLine("Calling.");
        }
    }
}
