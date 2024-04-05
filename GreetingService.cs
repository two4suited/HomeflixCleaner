namespace HomeflixCleaner
{
    public class GreetingService : IGreetingService
    {
        public void Greet(string message)
        {
            Console.WriteLine(message);
        }
    }
    public interface IGreetingService
{
    void Greet(string message);
}
}



