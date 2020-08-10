using System;
using BenchmarkDotNet.Running;

namespace Base58Check.Benchmark
{
    internal static class Program
    {
        static void Main()
        {
            var summary = BenchmarkRunner.Run<DecodeTests>();

            Console.WriteLine("==================================");
            Console.WriteLine("==================================");
            Console.WriteLine("==================================");
            Console.WriteLine(summary);
        }
    }
}