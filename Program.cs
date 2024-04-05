namespace HomeflixCleaner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddSingleton<ITimerService, TimerService>();
            services.AddSingleton<IGreetingService, GreetingService>();
            var serviceProvider = services.BuildServiceProvider();

            var interval = 1000; // Default interval
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "--interval" && i + 1 < args.Length && int.TryParse(args[i + 1], out int argInterval))
                {
                    interval = argInterval;
                    break;
                }
            }

            var timerService = serviceProvider.GetService<ITimerService>();
            timerService!.StartTimer(interval);

            Console.WriteLine("Press any key to stop the timer...");
            Console.ReadKey();
            ((IDisposable)serviceProvider).Dispose();
        }
    }
}

