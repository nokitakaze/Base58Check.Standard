# Benchmark for different algorithms

## Encoding
### Windows 10 & i7-6700K
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.301
  [Host]     : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT


```
|                                   Method |        N |     Mean |    Error |   StdDev |
|----------------------------------------- |--------- |---------:|---------:|---------:|
|                       **Encode_AdamCaudill** |  **1000000** |  **3.574 s** | **0.0124 s** | **0.0110 s** |
|                           Encode_FirstMy |  1000000 |  3.957 s | 0.0158 s | 0.0140 s |
|                              Encode_New1 |  1000000 |  3.935 s | 0.0286 s | 0.0223 s |
|                     Encode_New1a_Big_Big |  1000000 |  3.921 s | 0.0200 s | 0.0167 s |
|                  Encode_New1a_Big_Scalar |  1000000 |  4.009 s | 0.0173 s | 0.0153 s |
|                  Encode_New1a_Scalar_Big |  1000000 |  3.934 s | 0.0277 s | 0.0231 s |
|               Encode_New1a_Scalar_Scalar |  1000000 |  4.028 s | 0.0157 s | 0.0131 s |
|       Encode_New1a_Big_Big_StringBuilder |  1000000 |  4.038 s | 0.0177 s | 0.0166 s |
|    Encode_New1a_Big_Scalar_StringBuilder |  1000000 |  4.127 s | 0.0346 s | 0.0289 s |
|    Encode_New1a_Scalar_Big_StringBuilder |  1000000 |  4.060 s | 0.0149 s | 0.0140 s |
| Encode_New1a_Scalar_Scalar_StringBuilder |  1000000 |  4.112 s | 0.0124 s | 0.0110 s |
|                       **Encode_AdamCaudill** | **10000000** | **35.961 s** | **0.0755 s** | **0.0631 s** |
|                           Encode_FirstMy | 10000000 | 40.082 s | 0.0962 s | 0.0751 s |
|                              Encode_New1 | 10000000 | 39.093 s | 0.0578 s | 0.0452 s |
|                     Encode_New1a_Big_Big | 10000000 | 40.400 s | 0.4849 s | 0.4535 s |
|                  Encode_New1a_Big_Scalar | 10000000 | 40.615 s | 0.2227 s | 0.2083 s |
|                  Encode_New1a_Scalar_Big | 10000000 | 39.978 s | 0.1056 s | 0.0882 s |
|               Encode_New1a_Scalar_Scalar | 10000000 | 40.835 s | 0.2343 s | 0.2077 s |
|       Encode_New1a_Big_Big_StringBuilder | 10000000 | 41.037 s | 0.1659 s | 0.1385 s |
|    Encode_New1a_Big_Scalar_StringBuilder | 10000000 | 41.373 s | 0.1302 s | 0.1088 s |
|    Encode_New1a_Scalar_Big_StringBuilder | 10000000 | 41.259 s | 0.1433 s | 0.1196 s |
| Encode_New1a_Scalar_Scalar_StringBuilder | 10000000 | 41.605 s | 0.1704 s | 0.1423 s |

## Decoding
### Windows 10 & i7-6700K
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.301
  [Host]     : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT


```
|                  Method |       N |        Mean |     Error |    StdDev |
|------------------------ |-------- |------------:|----------:|----------:|
| **DecodePlain_AdamCaudill** |   **10000** |    **25.75 ms** |  **0.512 ms** |  **1.357 ms** |
|     DecodePlain_FirstMy |   10000 |    44.96 ms |  1.721 ms |  4.910 ms |
|        DecodePlain_New1 |   10000 |    33.27 ms |  0.276 ms |  0.244 ms |
|        DecodePlain_New2 |   10000 |    33.73 ms |  0.477 ms |  0.398 ms |
|        DecodePlain_New4 |   10000 |    34.86 ms |  0.676 ms |  0.751 ms |
|        DecodePlain_New5 |   10000 |    31.71 ms |  0.175 ms |  0.155 ms |
|        DecodePlain_New6 |   10000 |    31.45 ms |  0.418 ms |  0.370 ms |
|        DecodePlain_New7 |   10000 |    23.20 ms |  0.169 ms |  0.158 ms |
|        DecodePlain_New8 |   10000 |    22.87 ms |  0.160 ms |  0.133 ms |
|        DecodePlain_New9 |   10000 |    18.84 ms |  0.222 ms |  0.197 ms |
|       DecodePlain_New10 |   10000 |    33.40 ms |  0.384 ms |  0.359 ms |
| **DecodePlain_AdamCaudill** |  **100000** |   **241.22 ms** |  **2.384 ms** |  **2.230 ms** |
|     DecodePlain_FirstMy |  100000 |   384.03 ms |  4.092 ms |  3.628 ms |
|        DecodePlain_New1 |  100000 |   332.74 ms |  5.922 ms |  5.250 ms |
|        DecodePlain_New2 |  100000 |   344.13 ms |  5.676 ms |  4.740 ms |
|        DecodePlain_New4 |  100000 |   348.46 ms |  6.721 ms |  6.601 ms |
|        DecodePlain_New5 |  100000 |   315.01 ms |  2.608 ms |  2.312 ms |
|        DecodePlain_New6 |  100000 |   325.42 ms |  6.028 ms |  6.450 ms |
|        DecodePlain_New7 |  100000 |   238.89 ms |  2.217 ms |  1.851 ms |
|        DecodePlain_New8 |  100000 |   224.48 ms |  1.293 ms |  1.080 ms |
|        DecodePlain_New9 |  100000 |   192.77 ms |  3.814 ms |  8.372 ms |
|       DecodePlain_New10 |  100000 |   334.34 ms |  6.248 ms |  7.438 ms |
| **DecodePlain_AdamCaudill** | **1000000** | **2,419.17 ms** | **18.495 ms** | **15.444 ms** |
|     DecodePlain_FirstMy | 1000000 | 3,793.45 ms | 24.580 ms | 21.790 ms |
|        DecodePlain_New1 | 1000000 | 3,382.68 ms | 23.622 ms | 19.726 ms |
|        DecodePlain_New2 | 1000000 | 3,330.38 ms | 16.674 ms | 15.597 ms |
|        DecodePlain_New4 | 1000000 | 3,415.80 ms | 20.264 ms | 17.963 ms |
|        DecodePlain_New5 | 1000000 | 3,186.11 ms | 52.809 ms | 46.814 ms |
|        DecodePlain_New6 | 1000000 | 3,151.52 ms | 16.512 ms | 15.446 ms |
|        DecodePlain_New7 | 1000000 | 2,347.33 ms |  9.434 ms |  8.363 ms |
|        DecodePlain_New8 | 1000000 | 2,239.14 ms |  9.155 ms |  8.564 ms |
|        DecodePlain_New9 | 1000000 | 1,857.49 ms | 10.978 ms | 10.269 ms |
|       DecodePlain_New10 | 1000000 | 3,320.28 ms | 51.269 ms | 42.812 ms |

-------------------

### Ubuntu 16.04 & i7-2600
``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 16.04
Intel Core i7-2600 CPU 3.40GHz (Sandy Bridge), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.302
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  DefaultJob : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT


```
|                  Method |       N |        Mean |      Error |     StdDev |
|------------------------ |-------- |------------:|-----------:|-----------:|
| **DecodePlain_AdamCaudill** |   **10000** |    **39.17 ms** |   **0.775 ms** |   **1.316 ms** |
|     DecodePlain_FirstMy |   10000 |    63.01 ms |   0.954 ms |   0.893 ms |
|        DecodePlain_New1 |   10000 |    55.93 ms |   0.811 ms |   0.719 ms |
|        DecodePlain_New2 |   10000 |    55.29 ms |   1.064 ms |   1.267 ms |
|        DecodePlain_New4 |   10000 |    58.77 ms |   1.104 ms |   1.033 ms |
|        DecodePlain_New5 |   10000 |    53.82 ms |   0.988 ms |   0.825 ms |
|        DecodePlain_New6 |   10000 |    52.12 ms |   0.268 ms |   0.224 ms |
|        DecodePlain_New7 |   10000 |    37.66 ms |   0.690 ms |   0.990 ms |
|        DecodePlain_New8 |   10000 |    35.80 ms |   0.187 ms |   0.166 ms |
|        DecodePlain_New9 |   10000 |    30.62 ms |   0.553 ms |   0.490 ms |
|       DecodePlain_New10 |   10000 |    54.54 ms |   0.667 ms |   0.591 ms |
| **DecodePlain_AdamCaudill** |  **100000** |   **388.70 ms** |   **7.609 ms** |   **8.458 ms** |
|     DecodePlain_FirstMy |  100000 |   655.95 ms |  11.558 ms |  17.651 ms |
|        DecodePlain_New1 |  100000 |   574.26 ms |  10.803 ms |  12.440 ms |
|        DecodePlain_New2 |  100000 |   565.43 ms |   8.682 ms |   8.121 ms |
|        DecodePlain_New4 |  100000 |   564.52 ms |   7.421 ms |   6.197 ms |
|        DecodePlain_New5 |  100000 |   523.91 ms |  10.185 ms |  10.459 ms |
|        DecodePlain_New6 |  100000 |   507.77 ms |   5.825 ms |   5.164 ms |
|        DecodePlain_New7 |  100000 |   386.37 ms |   7.496 ms |   9.746 ms |
|        DecodePlain_New8 |  100000 |   395.60 ms |   5.719 ms |   5.070 ms |
|        DecodePlain_New9 |  100000 |   313.65 ms |   6.148 ms |   7.319 ms |
|       DecodePlain_New10 |  100000 |   572.15 ms |  11.361 ms |  16.653 ms |
| **DecodePlain_AdamCaudill** | **1000000** | **3,883.55 ms** |  **77.472 ms** | **103.423 ms** |
|     DecodePlain_FirstMy | 1000000 | 6,532.40 ms |  49.868 ms |  38.933 ms |
|        DecodePlain_New1 | 1000000 | 5,539.14 ms | 105.058 ms |  98.271 ms |
|        DecodePlain_New2 | 1000000 | 5,535.57 ms |  64.908 ms |  60.715 ms |
|        DecodePlain_New4 | 1000000 | 5,676.56 ms | 107.908 ms | 110.813 ms |
|        DecodePlain_New5 | 1000000 | 5,284.15 ms |  91.054 ms |  93.506 ms |
|        DecodePlain_New6 | 1000000 | 5,128.13 ms | 100.932 ms | 123.954 ms |
|        DecodePlain_New7 | 1000000 | 3,828.65 ms |  75.803 ms |  84.255 ms |
|        DecodePlain_New8 | 1000000 | 3,551.08 ms |  19.617 ms |  16.381 ms |
|        DecodePlain_New9 | 1000000 | 3,067.10 ms |  38.899 ms |  36.386 ms |
|       DecodePlain_New10 | 1000000 | 5,541.26 ms | 102.222 ms |  90.617 ms |

-------------------
### macOS Catalina 10.15.6 & i5-5350U

``` ini

BenchmarkDotNet=v0.12.1, OS=macOS Catalina 10.15.6 (19G73) [Darwin 19.6.0]
Intel Core i5-5350U CPU 1.80GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.302
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  DefaultJob : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT


```
|                  Method |       N |        Mean |     Error |    StdDev |
|------------------------ |-------- |------------:|----------:|----------:|
| **DecodePlain_AdamCaudill** |   **10000** |    **40.49 ms** |  **0.794 ms** |  **1.237 ms** |
|     DecodePlain_FirstMy |   10000 |    63.86 ms |  0.789 ms |  0.699 ms |
|        DecodePlain_New1 |   10000 |    53.77 ms |  0.118 ms |  0.098 ms |
|        DecodePlain_New2 |   10000 |    54.48 ms |  0.139 ms |  0.124 ms |
|        DecodePlain_New4 |   10000 |    57.56 ms |  0.150 ms |  0.133 ms |
|        DecodePlain_New5 |   10000 |    52.87 ms |  0.128 ms |  0.107 ms |
|        DecodePlain_New6 |   10000 |    52.16 ms |  0.145 ms |  0.136 ms |
|        DecodePlain_New7 |   10000 |    37.85 ms |  0.069 ms |  0.058 ms |
|        DecodePlain_New8 |   10000 |    35.92 ms |  0.082 ms |  0.072 ms |
|        DecodePlain_New9 |   10000 |    30.87 ms |  0.059 ms |  0.056 ms |
|       DecodePlain_New10 |   10000 |    55.48 ms |  0.159 ms |  0.141 ms |
| **DecodePlain_AdamCaudill** |  **100000** |   **385.95 ms** |  **1.112 ms** |  **1.040 ms** |
|     DecodePlain_FirstMy |  100000 |   634.11 ms |  1.797 ms |  1.593 ms |
|        DecodePlain_New1 |  100000 |   546.65 ms |  1.505 ms |  1.408 ms |
|        DecodePlain_New2 |  100000 |   542.45 ms |  1.074 ms |  1.005 ms |
|        DecodePlain_New4 |  100000 |   561.43 ms |  1.093 ms |  1.022 ms |
|        DecodePlain_New5 |  100000 |   528.40 ms |  1.884 ms |  1.573 ms |
|        DecodePlain_New6 |  100000 |   524.62 ms |  0.622 ms |  0.552 ms |
|        DecodePlain_New7 |  100000 |   376.06 ms |  1.043 ms |  0.924 ms |
|        DecodePlain_New8 |  100000 |   365.29 ms |  1.018 ms |  0.903 ms |
|        DecodePlain_New9 |  100000 |   306.68 ms |  0.673 ms |  0.597 ms |
|       DecodePlain_New10 |  100000 |   556.61 ms |  1.161 ms |  1.029 ms |
| **DecodePlain_AdamCaudill** | **1000000** | **3,717.80 ms** |  **8.301 ms** |  **7.765 ms** |
|     DecodePlain_FirstMy | 1000000 | 6,286.84 ms | 26.587 ms | 24.869 ms |
|        DecodePlain_New1 | 1000000 | 5,380.96 ms | 14.698 ms | 13.029 ms |
|        DecodePlain_New2 | 1000000 | 5,463.04 ms | 16.242 ms | 15.193 ms |
|        DecodePlain_New4 | 1000000 | 5,604.03 ms | 21.277 ms | 19.903 ms |
|        DecodePlain_New5 | 1000000 | 5,246.39 ms |  8.781 ms |  7.333 ms |
|        DecodePlain_New6 | 1000000 | 5,169.97 ms |  9.217 ms |  8.171 ms |
|        DecodePlain_New7 | 1000000 | 3,660.94 ms |  9.389 ms |  8.323 ms |
|        DecodePlain_New8 | 1000000 | 3,599.16 ms |  5.812 ms |  4.853 ms |
|        DecodePlain_New9 | 1000000 | 3,067.35 ms |  5.551 ms |  4.921 ms |
|       DecodePlain_New10 | 1000000 | 5,475.05 ms | 17.161 ms | 15.213 ms |

-------------------
### Windows 10 & i5-7400
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Intel Core i5-7400 CPU 3.00GHz (Kaby Lake), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=3.1.301
  [Host]     : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT


```
|                  Method |       N |        Mean |      Error |     StdDev |      Median |
|------------------------ |-------- |------------:|-----------:|-----------:|------------:|
| **DecodePlain_AdamCaudill** |   **10000** |    **34.41 ms** |   **0.687 ms** |   **0.818 ms** |    **34.61 ms** |
|     DecodePlain_FirstMy |   10000 |    55.96 ms |   1.109 ms |   1.883 ms |    56.75 ms |
|        DecodePlain_New1 |   10000 |    49.02 ms |   0.977 ms |   1.736 ms |    49.62 ms |
|        DecodePlain_New2 |   10000 |    49.69 ms |   0.985 ms |   1.413 ms |    50.14 ms |
|        DecodePlain_New4 |   10000 |    49.65 ms |   0.641 ms |   0.600 ms |    49.90 ms |
|        DecodePlain_New5 |   10000 |    45.37 ms |   0.898 ms |   1.596 ms |    45.76 ms |
|        DecodePlain_New6 |   10000 |    44.50 ms |   0.880 ms |   1.541 ms |    45.00 ms |
|        DecodePlain_New7 |   10000 |    33.52 ms |   0.317 ms |   0.265 ms |    33.59 ms |
|        DecodePlain_New8 |   10000 |    31.89 ms |   0.637 ms |   0.893 ms |    32.44 ms |
|        DecodePlain_New9 |   10000 |    27.03 ms |   0.539 ms |   0.755 ms |    27.28 ms |
|       DecodePlain_New10 |   10000 |    47.93 ms |   0.913 ms |   1.087 ms |    48.28 ms |
| **DecodePlain_AdamCaudill** |  **100000** |   **323.17 ms** |   **3.122 ms** |   **2.920 ms** |   **323.55 ms** |
|     DecodePlain_FirstMy |  100000 |   565.34 ms |   9.933 ms |   9.292 ms |   567.98 ms |
|        DecodePlain_New1 |  100000 |   487.25 ms |   4.198 ms |   3.926 ms |   488.06 ms |
|        DecodePlain_New2 |  100000 |   485.02 ms |   9.631 ms |  16.867 ms |   490.53 ms |
|        DecodePlain_New4 |  100000 |   491.22 ms |   9.589 ms |  16.541 ms |   496.17 ms |
|        DecodePlain_New5 |  100000 |   409.03 ms |   4.842 ms |   4.292 ms |   410.02 ms |
|        DecodePlain_New6 |  100000 |   412.82 ms |   5.651 ms |   4.719 ms |   414.23 ms |
|        DecodePlain_New7 |  100000 |   333.40 ms |   6.668 ms |  11.852 ms |   338.41 ms |
|        DecodePlain_New8 |  100000 |   323.04 ms |   6.433 ms |   9.629 ms |   325.94 ms |
|        DecodePlain_New9 |  100000 |   267.72 ms |   5.254 ms |   8.632 ms |   270.59 ms |
|       DecodePlain_New10 |  100000 |   433.97 ms |   7.086 ms |   5.917 ms |   433.65 ms |
| **DecodePlain_AdamCaudill** | **1000000** | **3,442.18 ms** |  **13.932 ms** |  **13.032 ms** | **3,442.44 ms** |
|     DecodePlain_FirstMy | 1000000 | 5,704.99 ms | 107.599 ms | 110.496 ms | 5,705.22 ms |
|        DecodePlain_New1 | 1000000 | 4,976.68 ms |  32.310 ms |  30.223 ms | 4,986.00 ms |
|        DecodePlain_New2 | 1000000 | 4,884.08 ms |  27.114 ms |  25.363 ms | 4,888.65 ms |
|        DecodePlain_New4 | 1000000 | 4,964.63 ms |  19.580 ms |  17.357 ms | 4,962.91 ms |
|        DecodePlain_New5 | 1000000 | 4,572.58 ms |  24.652 ms |  23.059 ms | 4,574.78 ms |
|        DecodePlain_New6 | 1000000 | 4,494.43 ms |  21.835 ms |  20.424 ms | 4,494.58 ms |
|        DecodePlain_New7 | 1000000 | 3,351.97 ms |  18.226 ms |  15.219 ms | 3,354.28 ms |
|        DecodePlain_New8 | 1000000 | 3,173.25 ms |  62.823 ms |  79.451 ms | 3,211.31 ms |
|        DecodePlain_New9 | 1000000 | 2,723.58 ms |  24.390 ms |  22.814 ms | 2,722.87 ms |
|       DecodePlain_New10 | 1000000 | 4,762.00 ms |  22.797 ms |  21.324 ms | 4,760.99 ms |

-------------------

### Windows 10 & i7-6700K

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.301
  [Host]     : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT


```
|            Method |       N |        Mean |     Error |    StdDev |
|------------------ |-------- |------------:|----------:|----------:|
|  **DecodePlain_New9** |   **10000** |    **19.03 ms** |  **0.137 ms** |  **0.121 ms** |
| DecodePlain_New11 |   10000 |    18.95 ms |  0.095 ms |  0.074 ms |
|  **DecodePlain_New9** |  **100000** |   **188.58 ms** |  **1.348 ms** |  **1.195 ms** |
| DecodePlain_New11 |  100000 |   190.40 ms |  2.174 ms |  2.033 ms |
|  **DecodePlain_New9** | **1000000** | **1,896.61 ms** | **13.334 ms** | **11.820 ms** |
| DecodePlain_New11 | 1000000 | 1,947.13 ms | 37.539 ms | 44.688 ms |

-------------------

