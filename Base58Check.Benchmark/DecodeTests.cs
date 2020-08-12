using System;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace Base58Check.Benchmark
{
    public class DecodeTests
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

        /*

        [Benchmark]
        public void DecodePlain_AdamCaudill()
        {
            foreach (var data in dataToDecode)
            {
                NokitaKaze.Base58Check.Old.Base58CheckEncoding.DecodePlain(data);
            }
        }

        [Benchmark]
        public void DecodePlain_FirstMy()
        {
            foreach (var data in dataToDecode)
            {
                NokitaKaze.Base58Check.Base58CheckEncoding.DecodePlain(data);
            }
        }

        [Benchmark]
        public void DecodePlain_New1()
        {
            foreach (var data in dataToDecode)
            {
                NokitaKaze.Base58Check.Base58CheckEncoding.DecodePlain1(data);
            }
        }

        [Benchmark]
        public void DecodePlain_New2()
        {
            foreach (var data in dataToDecode)
            {
                NokitaKaze.Base58Check.Base58CheckEncoding.DecodePlain2(data);
            }
        }

        [Benchmark]
        public void DecodePlain_New4()
        {
            foreach (var data in dataToDecode)
            {
                NokitaKaze.Base58Check.Base58CheckEncoding.DecodePlain4(data);
            }
        }

        [Benchmark]
        public void DecodePlain_New5()
        {
            foreach (var data in dataToDecode)
            {
                NokitaKaze.Base58Check.Base58CheckEncoding.DecodePlain5(data);
            }
        }

        [Benchmark]
        public void DecodePlain_New6()
        {
            foreach (var data in dataToDecode)
            {
                NokitaKaze.Base58Check.Base58CheckEncoding.DecodePlain6(data);
            }
        }

        [Benchmark]
        public void DecodePlain_New7()
        {
            foreach (var data in dataToDecode)
            {
                NokitaKaze.Base58Check.Base58CheckEncoding.DecodePlain7(data);
            }
        }

        [Benchmark]
        public void DecodePlain_New8()
        {
            foreach (var data in dataToDecode)
            {
                NokitaKaze.Base58Check.Base58CheckEncoding.DecodePlain8(data);
            }
        }
        
        */

        [Benchmark]
        public void DecodePlain_New9()
        {
            foreach (var data in dataToDecode)
            {
                NokitaKaze.Base58Check.Base58CheckEncoding.DecodePlain9(data);
            }
        }

        /*
        [Benchmark]
        public void DecodePlain_New10()
        {
            foreach (var data in dataToDecode)
            {
                NokitaKaze.Base58Check.Base58CheckEncoding.DecodePlain10(data);
            }
        }
        */
    }
}