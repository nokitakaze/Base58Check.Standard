using System;
using BenchmarkDotNet.Running;

namespace Base58Check.Benchmark
{
    internal static class Program
    {
        static void Main()
        {
            // var summaryDecode = BenchmarkRunner.Run<DecodeTests>();
            var summaryEncode = BenchmarkRunner.Run<EncodeTests>();

            Console.WriteLine("==================================");
            Console.WriteLine("==================================");
            Console.WriteLine("==================================");
            Console.WriteLine(summaryEncode);
        }
    }
}