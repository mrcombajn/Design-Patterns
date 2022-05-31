namespace DesignPatterns.Patterns.Strategy
{
    public class Call : CommunicationStrategy
    {
        public void Communicate()
        {
            Console.WriteLine("Calling.");
        }
    }
}
