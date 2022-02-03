using System;

namespace ex_telemetry
{
    class Program
    {
        static void Main(string[] args)
        {
            TelemetryBuffer.ToBuffer(Int64.MaxValue);
            Console.WriteLine("Hello World!");
        }
    }
}
