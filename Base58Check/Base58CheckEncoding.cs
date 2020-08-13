using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;

namespace NokitaKaze.Base58Check
{
    /// <summary>
    /// Base58Check Encoding / Decoding (Bitcoin-style)
    /// </summary>
    /// <remarks>
    /// See here for more details: https://en.bitcoin.it/wiki/Base58Check_encoding
    /// </remarks>
    public static class Base58CheckEncoding
    {
        public const int CHECK_SUM_SIZE = 4;

        /// <summary>
        /// "Don't want 0OIl characters that look the same in some fonts and"
        /// </summary>
        public const string ALPHABET = "123456789ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz";

        public static readonly BigInteger Base58BI = new BigInteger(58);
        public static readonly BigInteger Number256 = new BigInteger(256);

        private static readonly Dictionary<Base58DataType, IReadOnlyCollection<byte>> DataPrefixes =
            new Dictionary<Base58DataType, IReadOnlyCollection<byte>>()
            {
                // Main network
                {Base58DataType.P2PKH, new byte[] {0x00}},
                {Base58DataType.P2SH, new byte[] {0x05}},
                {Base58DataType.PRIVATE_KEY_WIF, new byte[] {0x80}},
                {Base58DataType.BIP32_PUBLIC_KEY, new byte[] {0x04, 0x88, 0xB2, 0x1E}},
                {Base58DataType.BIP32_PRIVATE_KEY, new byte[] {0x04, 0x88, 0xAD, 0xE4}},

                // Test network
                {Base58DataType.P2PKH_TESTNET, new byte[] {0x6F}},
                {Base58DataType.P2SH_TESTNET, new byte[] {0xC4}},
                {Base58DataType.PRIVATE_KEY_WIF_TESTNET, new byte[] {0xEF}},
                {Base58DataType.BIP32_PUBLIC_KEY_TESTNET, new byte[] {0x04, 0x35, 0x87, 0xCF}},
                {Base58DataType.BIP32_PRIVATE_KEY_TESTNET, new byte[] {0x04, 0x35, 0x83, 0x94}},
            };

        private static readonly IReadOnlyDictionary<char, int> ALPHABET_DIC;

        static Base58CheckEncoding()
        {
            ALPHABET_DIC = Enumerable
                .Range(0, ALPHABET.Length)
                .ToDictionary(t => ALPHABET[t], t => t);
        }

        #region Plain

        /// <summary>
        /// Encodes data in plain Base58, without any checksum
        /// </summary>
        /// <param name="input">The data to be encoded</param>
        /// <returns></returns>
        public static string EncodePlain(ICollection<byte> input)
        {
            BigInteger inputInteger;
            {
                inputInteger = BigInteger.Zero;
                // ReSharper disable once LoopCanBeConvertedToQuery
                foreach (var t in input)
                {
                    inputInteger = inputInteger * Number256 + t;
                }
            }

            var result = "";
            while (inputInteger > 0)
            {
                var charOffset = (int) (inputInteger % Base58BI);
                result = ALPHABET[charOffset] + result;
                inputInteger /= Base58BI;
            }

            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var t in input)
            {
                if (t != 0)
                {
                    break;
                }

                result = "1" + result;
            }

            return result;
        }

        /// <summary>
        /// Decodes data in plain Base58, without any checksum.
        /// </summary>
        /// <param name="data">Data to be decoded</param>
        /// <returns>Returns decoded data if valid; throws FormatException if invalid</returns>
        public static byte[] DecodePlain(string data)
        {
            BigInteger result;
            {
                result = BigInteger.Zero;

                foreach (var c in data)
                {
                    var digit = ALPHABET_DIC.ContainsKey(c) ? ALPHABET_DIC[c] : -1;
                    if (digit == -1)
                    {
                        throw new FormatException(string.Format("Invalid Base58 character `{0}`", c));
                    }

                    result = result * Base58BI + digit;
                }
            }

            // Faster than TakeWhile
            int prefixZeroCount;
            for (prefixZeroCount = 0;
                (prefixZeroCount < data.Length) && (data[prefixZeroCount] == '1');
                prefixZeroCount++)
            {
            }

            var resultReversed = result
                .ToByteArray()
                .Reverse()
                .ToArray();
            int firstNonZero;
            for (firstNonZero = 0;
                (firstNonZero < resultReversed.Length) && (resultReversed[firstNonZero] == 0);
                firstNonZero++)
            {
            }

            var revValueLength = resultReversed.Length - firstNonZero;
            var realOutput = new byte[prefixZeroCount + revValueLength];
            Array.Copy(resultReversed, firstNonZero, realOutput, prefixZeroCount, revValueLength);

            return realOutput;
        }

        #endregion

        #region Main Encoding

        /// <summary>
        /// Encodes data with a 4-byte checksum
        /// </summary>
        /// <param name="data">Data to be encoded</param>
        /// <returns></returns>
        public static string Encode(ICollection<byte> data)
        {
            var checksum = GetCheckSum(data);

            return EncodePlain(data.Concat(checksum).ToArray());
        }

        /// <summary>
        /// Decodes data in Base58Check format (with 4 byte checksum)
        /// </summary>
        /// <param name="data">Data to be decoded (without prefix)</param>
        /// <returns>Returns decoded data if valid; throws FormatException if invalid</returns>
        public static byte[] Decode(string data)
        {
            var decoded = DecodePlain(data);
            var dataItself = decoded.Take(decoded.Length - CHECK_SUM_SIZE).ToArray();
            var checksum = decoded.Skip(decoded.Length - CHECK_SUM_SIZE).ToArray();

            var realChecksum = GetCheckSum(dataItself);

            if (!realChecksum.SequenceEqual(checksum))
            {
                throw new FormatException("Base58 checksum is invalid");
            }

            return dataItself;
        }

        public static byte[] GetCheckSum(ICollection<byte> input)
        {
            using var sha256 = SHA256.Create();
            var hash1 = sha256.ComputeHash(input.ToArray());
            var hash2 = sha256.ComputeHash(hash1);

            return hash2.Take(CHECK_SUM_SIZE).ToArray();
        }

        #endregion

        #region Base58 types

        public static string EncodeType(ICollection<byte> data, Base58DataType base58DataType = Base58DataType.P2PKH)
        {
            if (base58DataType == Base58DataType.UNKNOWN)
            {
                throw new ArgumentOutOfRangeException();
            }

            var fullData = DataPrefixes[base58DataType]
                .Concat(data)
                .ToArray();

            return Encode(fullData);
        }

        public static byte[] DecodeIntoType(string data, out Base58DataType base58DataType)
        {
            var decodedData = Decode(data);
            foreach (var pair in DataPrefixes
                .Where(pair => pair.Value.Count <= decodedData.Length)
                .Where(pair => pair.Value.Select((v, index) => decodedData[index] == v).All(t => t))
            )
            {
                base58DataType = pair.Key;
                return decodedData.Skip(pair.Value.Count).ToArray();
            }

            base58DataType = Base58DataType.UNKNOWN;
            return decodedData;
        }

        #endregion
    }
}