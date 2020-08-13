using System;
using BenchmarkDotNet.Running;

namespace Base58Check.Benchmark
{
    internal static class Program
    {
        static void Main()
        {
            // var summaryDecode = BenchmarkRunner.Run<Base58Check.Benchmark.Algorithms.DecodeTests>();
            // var summaryEncode = BenchmarkRunner.Run<Base58Check.Benchmark.Algorithms.EncodeTests>();
            var summaryMain = BenchmarkRunner.Run<Base58Check.Benchmark.Main.MainTests>();

            Console.WriteLine("==================================");
            Console.WriteLine("==================================");
            Console.WriteLine("==================================");
            Console.WriteLine(summaryMain);
        }
    }
}