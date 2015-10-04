using System;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace Benchmark
{
    public class Runs
    {
        [Test]
        public void FilterAndSum()
        {
            var sw = Stopwatch.StartNew();
            var sum = Enumerable.Range(0, 1000000)
                                .Where(x => x % 1000 == 0)
                                .Sum();
            Console.WriteLine($"{sum}: {sw.ElapsedMilliseconds} ms");
        }

        [Test]
        public void FilterDivideAndSum()
        {
            var sw = Stopwatch.StartNew();
            var sum = Enumerable.Range(0, 1000000)
                                .Where(x => x % 1000 == 0)
                                .Select(x => x / 3.0)
                                .Sum();
            Console.WriteLine($"{sum}: {sw.ElapsedMilliseconds} ms");
        }
    }
}
