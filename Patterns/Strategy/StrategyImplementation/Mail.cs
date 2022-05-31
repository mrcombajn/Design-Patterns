using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Strategy
{
    internal class Mail : CommunicationStrategy
    {
        public void Communicate()
        {
            Console.WriteLine("Sending mail.");
        }
    }
}
