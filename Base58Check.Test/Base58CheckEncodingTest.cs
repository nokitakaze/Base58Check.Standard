using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace NokitaKaze.Base58Check.Test
{
    public class Base58CheckEncodingTest
    {
        public static IEnumerable<object[]> TestData()
        {
            var cases = new[]
            {
                ("2g", "61"),
                ("a3gV", "626262"),
                ("aPEr", "636363"),
                ("2cFupjhnEsSn59qHXstmK2ffpLv2", "73696d706c792061206c6f6e6720737472696e67"),
                ("1NS17iag9jJgTHD1VXjvLCEnZuQ3rJDE9L", "00eb15231dfceb60925886b67d065299925915aeb172c06647"),
                ("ABnLTmg", "516b6fcd0f"),
                ("3SEo3LWLoPntC", "bf4f89001e670274dd"),
                ("3EFU7m", "572e4794"),
                ("EJDM8drfXA6uyA", "ecac89cad93923c02321"),
                ("Rt5zm", "10c8511e"),

                //
                ("", ""),
                ("2", "01"),
                ("5R", "0100"),
                ("5T", "0102"),
                ("Ldm", "010200"),
                ("Ldp", "010203"),
                ("2VfUT", "01020300"),
                ("2VfUX", "01020304"),
                ("7bWpTR", "0102030400"),
                ("1", "00"),
                ("12", "0001"),
                ("15R", "000100"),
                ("15T", "000102"),
                ("1Ldm", "00010200"),
                ("1Ldp", "00010203"),
                ("12VfUT", "0001020300"),
                ("12VfUX", "0001020304"),
                ("17bWpTR", "000102030400"),
                ("11", "0000"),
                ("112", "000001"),
                ("115R", "00000100"),
                ("115T", "00000102"),
                ("11Ldm", "0000010200"),
                ("11Ldp", "0000010203"),
                ("112VfUT", "000001020300"),
                ("112VfUX", "000001020304"),
                ("117bWpTR", "00000102030400"),
                ("111", "000000"),
                ("1112", "00000001"),
                ("1115R", "0000000100"),
                ("1115T", "0000000102"),
                ("111Ldm", "000000010200"),
                ("111Ldp", "000000010203"),
                ("1112VfUT", "00000001020300"),
                ("1112VfUX", "00000001020304"),
                ("1117bWpTR", "0000000102030400"),
                ("1111", "00000000"),
                ("11112", "0000000001"),
                ("11115R", "000000000100"),
                ("11115T", "000000000102"),
                ("1111Ldm", "00000000010200"),
                ("1111Ldp", "00000000010203"),
                ("11112VfUT", "0000000001020300"),
                ("11112VfUX", "0000000001020304"),
                ("11117bWpTR", "000000000102030400"),

                //                
                ("9YmR", "1972ac"),
                ("4QHLBcQ", "1e26083185"),
                ("2qXrSm", "47db830a"),
                ("kJtqgesaJ", "13b4425e63280b"),
                ("Btu", "8f2a"),
                ("kcYha", "1d6ae5b5"),
                ("AUW", "7c7f"),
                ("amFPDWy7unF", "c9daec49a065dd20"),
                ("QA5JjHzZsuR", "8a71818b6d73e778"),
                ("2oNnVpDum", "d19a120e591c"),
                ("6KRezo", "d0099e4c"),
                ("BWBgZLLWuzR", "3ecb5cac41e2276a"),
                ("ATSPmB3CtY", "f986073f8f1ea9"),
                ("WS5akX9ENB5", "aff6fd3d69abe4c4"),
                ("5vK5Lncwzj", "81cf03cf5c3fd4"),
                ("xr59ywxg81od", "4ba524df2c91c00df8"),
                ("4MUQYNmkWVN", "140bcecafe9c0f59"),
                ("3yhbdsa9KB", "4e92d42077e886"),
                ("AyVhrAS", "5867d39d47"),
                ("PbQB", "434378"),
                ("2wJLu9hvp", "e183653d2f71"),
                ("busNBtsbXBw", "d0b8ecb6d067bf02"),
                ("29w8PuWC6", "86697685acf7"),
                ("2qQBHJ9ZPE", "3068a6253bccd9"),
                ("29zMhVFxt", "8686162dd541"),
                ("8VG", "6263"),
                ("5FPGbB", "a63099aa"),
                ("3C2CbBJ64", "ff139aafabd9"),
                ("hcvZ7sWkY3t", "f2d8eade35d5894b"),
                ("2vjhKmNF", "03de61304a50"),
                ("PaM2Accf", "2d5575071238"),
                ("G9Y", "c70b"),
                ("2vsNciY1S", "e0a611a01d2d"),
                ("7zgjsG7YSP", "b8933e43f70c3c"),
                ("58iNdtHmuU2", "18b5a35138793caf"),
                ("wTEj2bsw", "6d5936d2bbba"),
                ("6zXd24GszzR", "23d2aff4e339f6e6"),
                ("7gsBq52mdA", "b077b7124e3549"),
                ("Gn98", "2ef983"),
                ("EJ15kVK", "75d30ca4f6"),
                ("Sn7BboJQ", "33c3f6defdd9"),
                ("4WosGhz", "1f255c48f5"),
                ("YuPPRdQNmbQ", "bebc9f8802859d33"),
                ("6i5q", "10fea4"),
                ("A78zDSGhEC8", "3670adfea34feca9"),
                ("6ovVAUs2SEs", "22bad179dea62e10"),
                ("44MBzDnxVMRFL", "f0391bc4a6d64b091f"),
                ("3MNkhM", "5bfcb3f8"),
                ("MNJE", "3ca2fb"),
                ("5NPRaL3", "26b8f80834"),
                ("2xcnAjpLg8bn2", "99e5b688a6f6042623"),
                ("9C9", "6ba6"),
                ("PmndWCo", "c9d7b39a30"),
                ("gED3yN67", "4ec66fc1963c"),
                ("zgoT", "abbdea"),
                ("2S2fo", "f730e6"),
                ("3Aa3vdNXaR2", "0cf19481786257d5"),
                ("32RmCtjmJ", "ebcf96303199"),
                ("4US8h2K", "1ec874e634"),
                ("CoEi", "231f4b"),
                ("9VbUqit", "4b473cee15"),
                ("27Npc", "bfa8bd"),
                ("PxXuybrGYNJJ", "1f18b731f6f1dfd6c7"),
                ("SE7DaAmer", "0b7a2378152fbb"),
                ("2uer9dP359CNC", "95e1cd74350d170f99"),
                ("96SUAhzpQy", "d594d68773b352"),
                ("2En", "1043"),
                ("rgKfwQePx5wY", "434a4c58a55fd023c3"),
                ("fPRps2jfR6r", "e57fc013db18aae3"),
                ("228CWrzdnv", "1ae6583e0132cf"),
                ("4Cwswsbm", "067025101e78"),
                ("7HX", "5296"),
                ("FDv4Z8xL", "1c8fae46ecd5"),
                ("gzQ7bezpvcx", "ef151673979aa721"),
                ("5dYVY1Y", "2909ea0c4b"),
                ("2EqE1", "d5daca"),
                ("71zuRwCdf1", "9ec8c707b0c144"),
                ("2DsmFx9z1", "8e53fcd4fa82"),
                ("2w16aTX", "111db8106e"),
                ("N4hmtC5V4xM", "7deeb84e06678936"),
                ("3NBwxeB15yTSM", "b9d37b3836ff280e66"),
                ("49TRgfaHq7", "530318ce69550e"),
                ("J4Yp2FJ", "9739071dc9"),
                ("6gKHZo", "de20da0e"),
                ("7TRsPnVX3D", "aa5aba60989928"),
                ("5y3wm9", "c24b75e8"),
                ("7GZ", "525e"),
                ("GwD", "d164"),
                ("TXaw", "4ef9f8"),
                ("46PamCoDh71Ak", "f2fcee9c09205a1625"),
                ("7XR", "55bc"),
                ("4uJ363", "98a38034"),
                ("7T3Skp", "fc4c1c21"),
                ("7MrFou", "f8cb6b40"),
                ("FHb", "bbba"),
                ("8E8ctW8iYk", "beb15bc863a9fd"),
                ("5Hx", "3867"),
                ("U9Fv", "50ceb9"),
                ("4F6Td1WU", "06832ee4eb0d"),
                ("3Bu3RmUzmM66y", "abe2d0acf6d19ee04e"),
            };

            return cases.Select(t => new[] {t.Item1, t.Item2});
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void EncodePlainTest(string expectedBase58, string inputBytesString)
        {
            var bytes = Enumerable
                .Range(0, inputBytesString.Length / 2)
                .Select(t => Convert.ToByte(inputBytesString.Substring(t * 2, 2), 16))
                .ToArray();

            var actualBase58 = Base58CheckEncoding.EncodePlain(bytes);
            Assert.Equal(expectedBase58, actualBase58);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void DecodePlainTest(string inputString, string expectedBytesString)
        {
            var actualBytes = Base58CheckEncoding.DecodePlain(inputString);
            var actualHexString = string.Concat(actualBytes.Select(t => t.ToString("x2")));

            Assert.Equal(expectedBytesString, actualHexString);
        }

        public static IEnumerable<object[]> DecodeInvalidCharData()
        {
            var result = new List<string>();
            var poison = new[] {'0', 'O', 'I', 'l'};

            var prefixes = new[] {"", "ab", "zz", "11"};
            var postfixes = new[] {"", "ab", "zz", "11"};

            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var prefix in prefixes)
            {
                // ReSharper disable once LoopCanBeConvertedToQuery
                foreach (var poisonChar in poison)
                {
                    // ReSharper disable once LoopCanBeConvertedToQuery
                    foreach (var postfix in postfixes)
                    {
                        result.Add(prefix + poisonChar + postfix);
                    }
                }
            }

            return result.Select(t => new[] {t}).ToArray();
        }

        [Theory]
        [MemberData(nameof(DecodeInvalidCharData))]
        public void DecodeInvalidCharTest(string poison)
        {
            Assert.Throws<FormatException>(() => Base58CheckEncoding.DecodePlain(poison));
        }

        public static IEnumerable<object[]> EncodeBitcoinAddressData()
        {
            // ReSharper disable once UseObjectOrCollectionInitializer
            var result = new List<(string, string)>();
            result.Add(("16UwLL9Risc3QfPqBUvKofHmBQ7wMtjvM", "00010966776006953D5567439E5E39F86A0D273BEE"));

            return result
                .Select(t => new[] {t.Item1, t.Item2})
                .ToArray();
        }

        [Theory]
        [MemberData(nameof(EncodeBitcoinAddressData))]
        public void EncodeBitcoinAddress(string expectedString, string inputBytesString)
        {
            var bytes = Enumerable
                .Range(0, inputBytesString.Length / 2)
                .Select(t => Convert.ToByte(inputBytesString.Substring(t * 2, 2), 16))
                .ToArray();

            var actualText = Base58CheckEncoding.Encode(bytes);
            Assert.Equal(expectedString, actualText);
        }

        [Theory]
        [MemberData(nameof(EncodeBitcoinAddressData))]
        public void DecodeBitcoinAddress(string inputString, string expectedHex)
        {
            var actualBytes = Base58CheckEncoding.Decode(inputString);
            var actualHexString = string.Concat(actualBytes.Select(t => t.ToString("x2")));

            Assert.Equal(expectedHex.ToLowerInvariant(), actualHexString.ToLowerInvariant());
        }

        [Fact]
        public void DecodeBrokenBitcoinAddress()
        {
            Assert.Throws<FormatException>(() => Base58CheckEncoding.Decode("16UwLl9Risc3QfPqBUvKofHmBQ7wMtjvM"));
        }

        public static IEnumerable<object[]> EncodeTypeTestData()
        {
            // ReSharper disable once UseObjectOrCollectionInitializer
            var result = new List<(string, Base58DataType)>();
            result.Add(("1BitcoinEaterAddressDontSendf59kuE", Base58DataType.P2PKH));
            result.Add(("3Cbq7aT1tY8kMxWLbitaG7yT6bPbKChq64", Base58DataType.P2SH));
            result.Add((
                "xpub661MyMwAqRbcEYS8w7XLSVeEsBXy79zSzH1J8vCdxAZningWLdN3zgtU6LBpB85b3D2yc8sfvZU521AAwdZafEz7mnzBBsz4wKY5e4cp9LB",
                Base58DataType.BIP32_PUBLIC_KEY));
            result.Add((
                "xprv9s21ZrQH143K24Mfq5zL5MhWK9hUhhGbd45hLXo2Pq2oqzMMo63oStZzF93Y5wvzdUayhgkkFoicQZcP3y52uPPxFnfoLZB21Teqt1VvEHx",
                Base58DataType.BIP32_PRIVATE_KEY));
            result.Add((
                "zmk8tQY",
                Base58DataType.UNKNOWN));

            return result
                .Select(t => new object[] {t.Item1, t.Item2})
                .ToArray();
        }

        [Theory]
        [MemberData(nameof(EncodeTypeTestData))]
        public void EncodeTypeTest(string data, Base58DataType expectedBase58DataType)
        {
            var decodedData = Base58CheckEncoding.DecodeIntoType(data, out var actualDataType);

            Assert.Equal(expectedBase58DataType, actualDataType);
            if (expectedBase58DataType != Base58DataType.UNKNOWN)
            {
                var reEncodedData = Base58CheckEncoding.EncodeType(decodedData, actualDataType);
                Assert.Equal(data, reEncodedData);
            }
            else
            {
                Assert.Throws<ArgumentOutOfRangeException>(() =>
                    Base58CheckEncoding.EncodeType(decodedData, Base58DataType.UNKNOWN));
            }
        }
    }
}