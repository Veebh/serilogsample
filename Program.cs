using System;

namespace serilogsamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter option to write log.");
            WriteSerilog();
        }

        private static void WriteSerilog()
        {
            while (true)
            {
                Console.WriteLine("Enter 1 to log to Console.");
                var logQuote = Console.ReadLine();
                ISerilogProvider _logger=null;
                switch (logQuote)
                {
                    case "1":
                        _logger = new SerilogToConsole();
                        break;
                }
                _logger.LogData();
            }
        }
    }
}
