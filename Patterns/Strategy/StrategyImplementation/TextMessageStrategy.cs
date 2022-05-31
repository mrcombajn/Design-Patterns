namespace DesignPatterns.Patterns.Strategy
{
    public class TextMessageStrategy : CommunicationStrategy
    {
        public void Communicate()
        {
            Console.WriteLine("Sending text message.");
        }
    }
}
