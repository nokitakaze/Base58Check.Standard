using System;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace Base58Check.Benchmark
{
    public class EncodeTests
    {
        // ReSharper disable once ConvertToConstant.Global
        // ReSharper disable once FieldCanBeMadeReadOnly.Global
        [Params(10_000, 100_000, 1_000_000)] public int N = 0;
        private byte[][] dataToEncode;
        private string[] dataToDecode;

        [GlobalSetup]
        public void Setup()
        {
            var rnd = new Random(1488);
            dataToEncode = Enumerable
                .Range(0, N)
                .Select(t =>
                {
                    var i = rnd.Next(10, 20);
                    return Enumerable
                        .Range(0, i)
                        .Select(z => (byte) rnd.Next(0, 256))
                        .ToArray();
                })
                .ToArray();
            dataToDecode = dataToEncode
                .Select(NokitaKaze.Base58Check.Base58CheckEncoding.EncodePlain)
                .ToArray();
        }

        [Benchmark]
        public void EncodeOld()
        {
            foreach (var data in dataToEncode)
            {
                NokitaKaze.Base58Check.Old.Base58CheckEncoding.EncodePlain(data);
            }
        }

        [Benchmark]
        public void EncodeNew()
        {
            foreach (var data in dataToEncode)
            {
                NokitaKaze.Base58Check.Base58CheckEncoding.EncodePlain(data);
            }
        }
    }
}