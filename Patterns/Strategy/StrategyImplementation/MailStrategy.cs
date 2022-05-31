using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Strategy
{
    internal class MailStrategy : CommunicationStrategy
    {
        public void Communicate()
        {
            Console.WriteLine("Sending mail.");
        }
    }
}
