Base58Check
===========
[![NuGet version (NokitaKaze.Base58Check)](https://img.shields.io/nuget/v/NokitaKaze.Base58Check.svg?style=flat)](https://www.nuget.org/packages/NokitaKaze.Base58Check/)
[![Build status](https://ci.appveyor.com/api/projects/status/k7vma8jm754qcdnk/branch/master?svg=true)](https://ci.appveyor.com/project/nokitakaze/base58check-standard/branch/master)
[![Test status](https://img.shields.io/appveyor/tests/nokitakaze/base58check-standard.svg)](https://ci.appveyor.com/project/nokitakaze/base58check-standard/branch/master)
[![Downloads](https://img.shields.io/nuget/dt/NokitaKaze.Base58Check.svg)](https://www.nuget.org/packages/NokitaKaze.Base58Check)

Base58Check is a C# implementation of [Base58 Checked Encoding](https://en.bitcoin.it/wiki/Base58Check_encoding).

In short, Base58 is a encoding algorithm similar to Base64, removing certain characters that cause issues with URLs, and cause confusion because of how similar they look in certain fonts. Base58Check adds a 4 byte checksum to validate that the data hasn't been altered in transmission. This checksum isn't suitable to perform cryptographic validation, but is does detect accidental corruption.

## Installation

[NuGet Package](https://www.nuget.org/packages/NokitaKaze.Base58Check/)

## Public Interface

* **`Base58Check.Encode(ICollection<byte>)`** - Encodes data with a 4-byte checksum (standard variant for encoding)
* **`Base58Check.Decode(string)`** - Decodes data in Base58Check format with 4 byte checksum (standard variant for decoding)
* **`Base58Check.EncodePlain(ICollection<byte>)`** - Encodes data in plain Base58, without any checksum
* **`Base58Check.DecodePlain(string)`** - Decodes data in plain Base58, without any checksum

The `Encode*` methods both expect a byte array of arbitrary length; as the entire payload to encode must be loaded into memory, an `OutOfMemoryException` may be thrown for large payloads. The `Decode*` methods will throw a `FormatException` if the string passed in isn't in a valid Base58 format; the `Decode` method will also throw the `FormatException` if the checksum verification fails.

## Benchmark
- [Main benchmarks](docs/main-benchmark.md)
- [Benchmarks for different variants of algorithms](docs/algo-benchmark.md)

## License
Licensed under the Apache License

Original authors: Adam Caudill <adam@adamcaudill.com> & Symon Rottem <s.rottem@symco.com.au>

Obsolete encoding/decoding implementation based on a [public domain Gist](https://gist.github.com/CodesInChaos/3175971) by @CodesInChaos.
