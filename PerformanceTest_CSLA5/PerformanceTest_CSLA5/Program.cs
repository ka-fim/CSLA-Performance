using System;
using System.Diagnostics;

namespace PerformanceTest_CSLA5
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();
            var result = PerformanceTestEntity.GetAll();
            sw.Stop();
            Console.WriteLine($"Fetching {result.Count} items took {sw.ElapsedMilliseconds}ms");
            Console.ReadKey();
        }
    }
}
