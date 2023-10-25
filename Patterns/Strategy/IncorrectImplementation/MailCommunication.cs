using System;

namespace DesignPatterns.Patterns.Strategy.IncorrectImplementation
{
    public class MailCommunication
    {
        public void Communicate()
        {
            Console.WriteLine("Sending mail.");
        }
    }
}
