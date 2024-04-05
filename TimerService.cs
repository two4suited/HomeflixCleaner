namespace HomeflixCleaner
{
    public class TimerService(IGreetingService greetingService) : ITimerService
    {
        private System.Timers.Timer _timer;
        public void StartTimer( int intervalInMilliseconds)
        {            
            _timer = new System.Timers.Timer(intervalInMilliseconds); // 60000 milliseconds = 1 minute
            _timer.Elapsed += (sender, e) => greetingService.Greet("Hello, World!");
            _timer.Start();
        }
    }
} 

