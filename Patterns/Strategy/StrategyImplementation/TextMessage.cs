namespace DesignPatterns.Patterns.Strategy
{
    public class TextMessage : CommunicationStrategy
    {
        public void Communicate()
        {
            Console.WriteLine("Sending text message.");
        }
    }
}
