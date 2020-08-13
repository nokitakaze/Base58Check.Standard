using System;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace Base58Check.Benchmark.Main
{
    public class MainTests
    {
        // ReSharper disable once ConvertToConstant.Global
        // ReSharper disable once FieldCanBeMadeReadOnly.Global
        [Params(1_000, 10_000, 100_000)] public int N = 0;

        // ReSharper disable once ConvertToConstant.Global
        // ReSharper disable once FieldCanBeMadeReadOnly.Global
        [Params(25, 100, 1024)] public int ByteLength = 0;

        private byte[][] dataToEncode;
        private string[] dataToDecode;

        [GlobalSetup]
        public void Setup()
        {
            var rnd = new Random(911);
            dataToEncode = Enumerable
                .Range(0, N)
                .Select(t => Enumerable
                    .Range(0, ByteLength)
                    .Select(z => (byte) rnd.Next(0, 256))
                    .ToArray()
                )
                .ToArray();
            dataToDecode = dataToEncode
                .Select(NokitaKaze.Base58Check.Base58CheckEncoding.EncodePlain)
                .ToArray();
        }

        [Benchmark]
        public void DecodePlain()
        {
            foreach (var data in dataToDecode)
            {
                NokitaKaze.Base58Check.Base58CheckEncoding.DecodePlain(data);
            }
        }

        [Benchmark]
        public void EncodePlain()
        {
            foreach (var data in dataToEncode)
            {
                NokitaKaze.Base58Check.Base58CheckEncoding.EncodePlain(data);
            }
        }
    }
}