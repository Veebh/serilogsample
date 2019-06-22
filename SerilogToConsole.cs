using Serilog;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace serilogsamples
{
    internal class SerilogToConsole : ISerilogProvider
    {
        public SerilogToConsole()
        {
            Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
        }

        public static Logger Logger { get; set; }

        internal static void WriteSerilog()
        {
            Logger.Information("Serilog logging sameple. Info");
        }

        public void LogData()
        {
            WriteSerilog();
        }
    }
}
