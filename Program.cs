using System;
using System.Diagnostics;

namespace VSCodeSlowConditionalBreakpoint
{
    class Program
    {
        static void Main(string[] args)
        {
			Stopwatch stopwatch = Stopwatch.StartNew();

            for (var i = 0; i < 1000; i++)
			{
				if(i > 1000) break;
			}

			stopwatch.Stop();
			Console.WriteLine($"Elapsed: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
