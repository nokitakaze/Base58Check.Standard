using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using NokitaKaze.Base58Check;

namespace Base58Check.Benchmark
{
    public class EncodeTests
    {
        // ReSharper disable once ConvertToConstant.Global
        // ReSharper disable once FieldCanBeMadeReadOnly.Global
        [Params(1_000_000, 10_000_000)] public int N = 0; // 10_000,100_000, 
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
                .Select(Base58CheckEncoding.EncodePlain)
                .ToArray();
        }

        [Benchmark]
        public void Encode_AdamCaudill()
        {
            foreach (var data in dataToEncode)
            {
                NokitaKaze.Base58Check.Old.Base58CheckEncoding.EncodePlain(data);
            }
        }

        [Benchmark]
        public void Encode_FirstMy()
        {
            foreach (var data in dataToEncode)
            {
                Base58CheckEncoding.EncodePlain(data);
            }
        }

        [Benchmark]
        public void Encode_New1()
        {
            foreach (var data in dataToEncode)
            {
                Base58CheckEncoding.EncodeNew1(data);
            }
        }

        [Benchmark]
        public void Encode_New1a_Big_Big()
        {
            foreach (var data in dataToEncode)
            {
                Base58CheckEncoding.EncodeNew1a_Big_Big(data);
            }
        }

        [Benchmark]
        public void Encode_New1a_Big_Scalar()
        {
            foreach (var data in dataToEncode)
            {
                Base58CheckEncoding.EncodeNew1a_Big_Scalar(data);
            }
        }

        [Benchmark]
        public void Encode_New1a_Scalar_Big()
        {
            foreach (var data in dataToEncode)
            {
                Base58CheckEncoding.EncodeNew1a_Scalar_Big(data);
            }
        }

        [Benchmark]
        public void Encode_New1a_Scalar_Scalar()
        {
            foreach (var data in dataToEncode)
            {
                Base58CheckEncoding.EncodeNew1a_Scalar_Scalar(data);
            }
        }

        [Benchmark]
        public void Encode_New1a_Big_Big_StringBuilder()
        {
            foreach (var data in dataToEncode)
            {
                Base58CheckEncoding.EncodeNew1a_Big_Big_StringBuilder(data);
            }
        }

        [Benchmark]
        public void Encode_New1a_Big_Scalar_StringBuilder()
        {
            foreach (var data in dataToEncode)
            {
                Base58CheckEncoding.EncodeNew1a_Big_Scalar_StringBuilder(data);
            }
        }

        [Benchmark]
        public void Encode_New1a_Scalar_Big_StringBuilder()
        {
            foreach (var data in dataToEncode)
            {
                Base58CheckEncoding.EncodeNew1a_Scalar_Big_StringBuilder(data);
            }
        }

        [Benchmark]
        public void Encode_New1a_Scalar_Scalar_StringBuilder()
        {
            foreach (var data in dataToEncode)
            {
                Base58CheckEncoding.EncodeNew1a_Scalar_Scalar_StringBuilder(data);
            }
        }
    }
}