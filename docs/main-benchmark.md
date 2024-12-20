# Main benchmark
## Windows 10 & AMD Ryzen 9 7950X 4.5 GHz (Raphael) (v0.4.3)
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19045
AMD Ryzen 9 7950X, 1 CPU, 32 logical and 16 physical cores
.NET Core SDK=8.0.404
  [Host]     : .NET Core 8.0.11 (CoreCLR 8.0.1124.51707, CoreFX 8.0.1124.51707), X64 RyuJIT
  DefaultJob : .NET Core 8.0.11 (CoreCLR 8.0.1124.51707, CoreFX 8.0.1124.51707), X64 RyuJIT


```
|      Method |      N | ByteLength |           Mean |       Error |      StdDev |
|------------ |------- |----------- |---------------:|------------:|------------:|
| **DecodePlain** |   **1000** |         **25** |       **1.021 ms** |   **0.0039 ms** |   **0.0036 ms** |
| EncodePlain |   1000 |         25 |       1.810 ms |   0.0096 ms |   0.0090 ms |
| **DecodePlain** |   **1000** |        **100** |       **5.321 ms** |   **0.0187 ms** |   **0.0156 ms** |
| EncodePlain |   1000 |        100 |      15.193 ms |   0.0755 ms |   0.0631 ms |
| **DecodePlain** |   **1000** |       **1024** |     **197.252 ms** |   **1.7391 ms** |   **1.6268 ms** |
| EncodePlain |   1000 |       1024 |   1,342.195 ms |   5.2312 ms |   4.8933 ms |
| **DecodePlain** |  **10000** |         **25** |      **10.057 ms** |   **0.0925 ms** |   **0.0865 ms** |
| EncodePlain |  10000 |         25 |      18.008 ms |   0.0573 ms |   0.0536 ms |
| **DecodePlain** |  **10000** |        **100** |      **53.721 ms** |   **0.1780 ms** |   **0.1665 ms** |
| EncodePlain |  10000 |        100 |     151.616 ms |   0.9402 ms |   0.8794 ms |
| **DecodePlain** |  **10000** |       **1024** |   **1,999.590 ms** |  **11.4609 ms** |  **10.7205 ms** |
| EncodePlain |  10000 |       1024 |  13,335.758 ms |  50.2213 ms |  46.9770 ms |
| **DecodePlain** | **100000** |         **25** |     **101.961 ms** |   **0.3904 ms** |   **0.3260 ms** |
| EncodePlain | 100000 |         25 |     183.789 ms |   2.3378 ms |   2.1868 ms |
| **DecodePlain** | **100000** |        **100** |     **530.640 ms** |   **2.0418 ms** |   **1.5941 ms** |
| EncodePlain | 100000 |        100 |   1,532.633 ms |   9.2513 ms |   8.6536 ms |
| **DecodePlain** | **100000** |       **1024** |  **19,662.650 ms** |  **19.8876 ms** |  **18.6029 ms** |
| EncodePlain | 100000 |       1024 | 133,207.738 ms | 243.7186 ms | 227.9745 ms |


## Windows 10 & AMD Ryzen 5 7535HS 3.3 GHz (Rembrandt R) (v0.4.3)
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19045
AMD Ryzen 5 7535HS with Radeon Graphics, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=8.0.404
  [Host]     : .NET Core 8.0.11 (CoreCLR 8.0.1124.51707, CoreFX 8.0.1124.51707), X64 RyuJIT
  DefaultJob : .NET Core 8.0.11 (CoreCLR 8.0.1124.51707, CoreFX 8.0.1124.51707), X64 RyuJIT


```
|      Method |      N | ByteLength |           Mean |       Error |      StdDev |
|------------ |------- |----------- |---------------:|------------:|------------:|
| **DecodePlain** |   **1000** |         **25** |       **1.453 ms** |   **0.0282 ms** |   **0.0463 ms** |
| EncodePlain |   1000 |         25 |       2.775 ms |   0.0552 ms |   0.0774 ms |
| **DecodePlain** |   **1000** |        **100** |       **7.785 ms** |   **0.1294 ms** |   **0.1211 ms** |
| EncodePlain |   1000 |        100 |      23.464 ms |   0.4636 ms |   0.6345 ms |
| **DecodePlain** |   **1000** |       **1024** |     **268.729 ms** |   **5.3649 ms** |  **12.2187 ms** |
| EncodePlain |   1000 |       1024 |   1,680.330 ms |  32.5655 ms |  36.1965 ms |
| **DecodePlain** |  **10000** |         **25** |      **13.383 ms** |   **0.2573 ms** |   **0.2643 ms** |
| EncodePlain |  10000 |         25 |      26.254 ms |   0.5126 ms |   0.5485 ms |
| **DecodePlain** |  **10000** |        **100** |      **70.810 ms** |   **1.3688 ms** |   **1.5214 ms** |
| EncodePlain |  10000 |        100 |     220.008 ms |   4.3025 ms |   4.2256 ms |
| **DecodePlain** |  **10000** |       **1024** |   **2,509.196 ms** |  **17.7920 ms** |  **16.6426 ms** |
| EncodePlain |  10000 |       1024 |  16,597.741 ms | 169.3088 ms | 158.3716 ms |
| **DecodePlain** | **100000** |         **25** |     **132.307 ms** |   **1.3890 ms** |   **1.2993 ms** |
| EncodePlain | 100000 |         25 |     261.713 ms |   5.0116 ms |   5.9660 ms |
| **DecodePlain** | **100000** |        **100** |     **688.827 ms** |   **6.2867 ms** |   **5.8806 ms** |
| EncodePlain | 100000 |        100 |   2,160.717 ms |   6.7082 ms |   5.9467 ms |
| **DecodePlain** | **100000** |       **1024** |  **25,337.582 ms** |  **61.2502 ms** |  **54.2967 ms** |
| EncodePlain | 100000 |       1024 | 165,460.280 ms | 278.8848 ms | 260.8691 ms |


## Windows 10 & Intel Core i7-10875H CPU 2.30GHz (v0.4.3)
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19045
Intel Core i7-10875H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=8.0.404
  [Host]     : .NET Core 8.0.11 (CoreCLR 8.0.1124.51707, CoreFX 8.0.1124.51707), X64 RyuJIT
  DefaultJob : .NET Core 8.0.11 (CoreCLR 8.0.1124.51707, CoreFX 8.0.1124.51707), X64 RyuJIT


```
|      Method |      N | ByteLength |           Mean |         Error |        StdDev |         Median |
|------------ |------- |----------- |---------------:|--------------:|--------------:|---------------:|
| **DecodePlain** |   **1000** |         **25** |       **1.593 ms** |     **0.0302 ms** |     **0.0296 ms** |       **1.592 ms** |
| EncodePlain |   1000 |         25 |       4.264 ms |     0.0843 ms |     0.2131 ms |       4.192 ms |
| **DecodePlain** |   **1000** |        **100** |       **7.939 ms** |     **0.0661 ms** |     **0.0619 ms** |       **7.937 ms** |
| EncodePlain |   1000 |        100 |      39.104 ms |     0.6184 ms |     0.5784 ms |      39.003 ms |
| **DecodePlain** |   **1000** |       **1024** |     **301.836 ms** |     **5.9253 ms** |     **6.5859 ms** |     **299.669 ms** |
| EncodePlain |   1000 |       1024 |   3,645.914 ms |    72.1097 ms |   116.4437 ms |   3,702.238 ms |
| **DecodePlain** |  **10000** |         **25** |      **15.724 ms** |     **0.2618 ms** |     **0.3310 ms** |      **15.559 ms** |
| EncodePlain |  10000 |         25 |      42.960 ms |     0.8275 ms |     1.0465 ms |      43.534 ms |
| **DecodePlain** |  **10000** |        **100** |      **86.726 ms** |     **0.2636 ms** |     **0.2466 ms** |      **86.753 ms** |
| EncodePlain |  10000 |        100 |     426.582 ms |     2.6840 ms |     2.5106 ms |     426.529 ms |
| **DecodePlain** |  **10000** |       **1024** |   **2,934.862 ms** |     **5.4448 ms** |     **4.5467 ms** |   **2,933.847 ms** |
| EncodePlain |  10000 |       1024 |  35,613.953 ms |   382.9817 ms |   319.8071 ms |  35,511.642 ms |
| **DecodePlain** | **100000** |         **25** |     **154.093 ms** |     **1.7607 ms** |     **1.4702 ms** |     **154.197 ms** |
| EncodePlain | 100000 |         25 |     438.151 ms |     5.5460 ms |     5.1877 ms |     439.479 ms |
| **DecodePlain** | **100000** |        **100** |     **835.020 ms** |    **16.1660 ms** |    **18.6168 ms** |     **838.009 ms** |
| EncodePlain | 100000 |        100 |   4,406.068 ms |    41.6285 ms |    38.9394 ms |   4,408.053 ms |
| **DecodePlain** | **100000** |       **1024** |  **29,947.625 ms** |   **714.0369 ms** | **2,105.3540 ms** |  **28,585.261 ms** |
| EncodePlain | 100000 |       1024 | 326,758.725 ms | 1,770.8276 ms | 1,656.4332 ms | 327,285.767 ms |


## Windows 10 & AMD Ryzen 9 3900X BOX 3.8 GHz (Matisse) (v0.4.3)
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19045
AMD Ryzen 9 3900X, 1 CPU, 24 logical and 12 physical cores
.NET Core SDK=8.0.300
  [Host]     : .NET Core 8.0.5 (CoreCLR 8.0.524.21615, CoreFX 8.0.524.21615), X64 RyuJIT
  DefaultJob : .NET Core 8.0.5 (CoreCLR 8.0.524.21615, CoreFX 8.0.524.21615), X64 RyuJIT


```
|      Method |      N | ByteLength |           Mean |       Error |      StdDev |
|------------ |------- |----------- |---------------:|------------:|------------:|
| **DecodePlain** |   **1000** |         **25** |       **1.412 ms** |   **0.0080 ms** |   **0.0071 ms** |
| EncodePlain |   1000 |         25 |       3.296 ms |   0.0174 ms |   0.0163 ms |
| **DecodePlain** |   **1000** |        **100** |       **7.358 ms** |   **0.0479 ms** |   **0.0448 ms** |
| EncodePlain |   1000 |        100 |      31.585 ms |   0.2200 ms |   0.2058 ms |
| **DecodePlain** |   **1000** |       **1024** |     **285.613 ms** |   **1.8757 ms** |   **1.6628 ms** |
| EncodePlain |   1000 |       1024 |   2,688.172 ms |  17.5966 ms |  16.4599 ms |
| **DecodePlain** |  **10000** |         **25** |      **13.844 ms** |   **0.0305 ms** |   **0.0286 ms** |
| EncodePlain |  10000 |         25 |      36.272 ms |   0.7159 ms |   0.9054 ms |
| **DecodePlain** |  **10000** |        **100** |      **76.948 ms** |   **0.9134 ms** |   **0.8544 ms** |
| EncodePlain |  10000 |        100 |     342.626 ms |   2.6902 ms |   2.5164 ms |
| **DecodePlain** |  **10000** |       **1024** |   **2,837.929 ms** |   **4.4152 ms** |   **3.9140 ms** |
| EncodePlain |  10000 |       1024 |  26,810.965 ms |  73.9151 ms |  69.1402 ms |
| **DecodePlain** | **100000** |         **25** |     **138.509 ms** |   **0.9478 ms** |   **0.8866 ms** |
| EncodePlain | 100000 |         25 |     337.303 ms |   1.6980 ms |   1.4179 ms |
| **DecodePlain** | **100000** |        **100** |     **727.243 ms** |   **4.9930 ms** |   **4.6704 ms** |
| EncodePlain | 100000 |        100 |   3,156.047 ms |  19.5064 ms |  17.2919 ms |
| **DecodePlain** | **100000** |       **1024** |  **28,418.573 ms** |  **68.0749 ms** |  **63.6773 ms** |
| EncodePlain | 100000 |       1024 | 268,150.667 ms | 139.7584 ms | 116.7046 ms |


## Windows 10 & AMD Ryzen 9 3900X BOX 3.8 GHz (Matisse) (v0.4.2)
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.450 (2004/?/20H1)
AMD Ryzen 9 3900X, 1 CPU, 24 logical and 12 physical cores
.NET Core SDK=3.1.401
  [Host]     : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT


```
|      Method |      N | ByteLength |           Mean |       Error |      StdDev |
|------------ |------- |----------- |---------------:|------------:|------------:|
| **DecodePlain** |   **1000** |         **25** |       **3.019 ms** |   **0.0231 ms** |   **0.0205 ms** |
| EncodePlain |   1000 |         25 |       5.330 ms |   0.0243 ms |   0.0216 ms |
| **DecodePlain** |   **1000** |        **100** |      **15.888 ms** |   **0.0749 ms** |   **0.0701 ms** |
| EncodePlain |   1000 |        100 |      43.628 ms |   0.1894 ms |   0.1772 ms |
| **DecodePlain** |   **1000** |       **1024** |     **607.207 ms** |   **2.4616 ms** |   **1.9219 ms** |
| EncodePlain |   1000 |       1024 |   3,192.719 ms |   5.7005 ms |   4.7602 ms |
| **DecodePlain** |  **10000** |         **25** |      **31.321 ms** |   **0.2663 ms** |   **0.2491 ms** |
| EncodePlain |  10000 |         25 |      53.570 ms |   0.2575 ms |   0.2283 ms |
| **DecodePlain** |  **10000** |        **100** |     **165.616 ms** |   **0.5398 ms** |   **0.4508 ms** |
| EncodePlain |  10000 |        100 |     437.195 ms |   2.6645 ms |   2.3620 ms |
| **DecodePlain** |  **10000** |       **1024** |   **6,026.756 ms** |  **33.2982 ms** |  **29.5179 ms** |
| EncodePlain |  10000 |       1024 |  31,763.862 ms |  23.1114 ms |  20.4877 ms |
| **DecodePlain** | **100000** |         **25** |     **312.623 ms** |   **1.4673 ms** |   **1.3007 ms** |
| EncodePlain | 100000 |         25 |     539.761 ms |   2.5686 ms |   2.2770 ms |
| **DecodePlain** | **100000** |        **100** |   **1,617.721 ms** |   **7.0742 ms** |   **6.6172 ms** |
| EncodePlain | 100000 |        100 |   4,336.208 ms |   9.1414 ms |   8.5509 ms |
| **DecodePlain** | **100000** |       **1024** |  **59,624.377 ms** |  **66.5021 ms** |  **58.9524 ms** |
| EncodePlain | 100000 |       1024 | 318,303.823 ms | 228.4905 ms | 190.7999 ms |

## Windows 10 & Intel Core i7-6700K CPU 4.00GHz (Skylake) (v0.4.2)
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.301
  [Host]     : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT


```
|      Method |      N | ByteLength |           Mean |       Error |      StdDev |
|------------ |------- |----------- |---------------:|------------:|------------:|
| **DecodePlain** |   **1000** |         **25** |       **3.354 ms** |   **0.0150 ms** |   **0.0117 ms** |
| EncodePlain |   1000 |         25 |       6.679 ms |   0.1137 ms |   0.1063 ms |
| **DecodePlain** |   **1000** |        **100** |      **16.755 ms** |   **0.1082 ms** |   **0.1012 ms** |
| EncodePlain |   1000 |        100 |      56.104 ms |   0.3744 ms |   0.3126 ms |
| **DecodePlain** |   **1000** |       **1024** |     **530.145 ms** |   **7.3718 ms** |   **6.5349 ms** |
| EncodePlain |   1000 |       1024 |   4,135.537 ms |  25.3529 ms |  23.7151 ms |
| **DecodePlain** |  **10000** |         **25** |      **32.627 ms** |   **0.3680 ms** |   **0.3262 ms** |
| EncodePlain |  10000 |         25 |      65.417 ms |   0.6999 ms |   0.6547 ms |
| **DecodePlain** |  **10000** |        **100** |     **169.452 ms** |   **1.3537 ms** |   **1.2000 ms** |
| EncodePlain |  10000 |        100 |     554.826 ms |   3.5949 ms |   3.3627 ms |
| **DecodePlain** |  **10000** |       **1024** |   **5,150.081 ms** |  **15.8682 ms** |  **13.2507 ms** |
| EncodePlain |  10000 |       1024 |  41,209.795 ms | 192.3740 ms | 179.9467 ms |
| **DecodePlain** | **100000** |         **25** |     **356.748 ms** |   **4.3948 ms** |   **4.1109 ms** |
| EncodePlain | 100000 |         25 |     660.339 ms |   6.0679 ms |   5.6759 ms |
| **DecodePlain** | **100000** |        **100** |   **1,661.173 ms** |   **7.4508 ms** |   **6.2217 ms** |
| EncodePlain | 100000 |        100 |   5,474.526 ms |  10.6219 ms |   9.9358 ms |
| **DecodePlain** | **100000** |       **1024** |  **51,857.771 ms** | **406.8083 ms** | **360.6249 ms** |
| EncodePlain | 100000 |       1024 | 411,562.725 ms | 349.2002 ms | 291.5980 ms |

## ubuntu 16.04 & Intel Core i7-2600 CPU 3.40GHz (Sandy Bridge) (v0.4.2)
``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 16.04
Intel Core i7-2600 CPU 3.40GHz (Sandy Bridge), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.302
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  DefaultJob : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT


```
|      Method |      N | ByteLength |           Mean |       Error |      StdDev |
|------------ |------- |----------- |---------------:|------------:|------------:|
| **DecodePlain** |   **1000** |         **25** |       **5.485 ms** |   **0.0787 ms** |   **0.0736 ms** |
| EncodePlain |   1000 |         25 |      10.249 ms |   0.0874 ms |   0.0775 ms |
| **DecodePlain** |   **1000** |        **100** |      **26.215 ms** |   **0.2398 ms** |   **0.2002 ms** |
| EncodePlain |   1000 |        100 |      77.403 ms |   0.8846 ms |   0.8275 ms |
| **DecodePlain** |   **1000** |       **1024** |     **809.052 ms** |   **5.0243 ms** |   **3.9226 ms** |
| EncodePlain |   1000 |       1024 |   5,066.844 ms |  31.0788 ms |  29.0712 ms |
| **DecodePlain** |  **10000** |         **25** |      **55.551 ms** |   **1.0640 ms** |   **1.1827 ms** |
| EncodePlain |  10000 |         25 |     101.479 ms |   1.3417 ms |   1.1894 ms |
| **DecodePlain** |  **10000** |        **100** |     **265.484 ms** |   **4.7776 ms** |   **3.9895 ms** |
| EncodePlain |  10000 |        100 |     773.929 ms |  13.7389 ms |  12.1792 ms |
| **DecodePlain** |  **10000** |       **1024** |   **8,097.992 ms** | **132.7284 ms** | **110.8342 ms** |
| EncodePlain |  10000 |       1024 |  50,845.724 ms | 515.5204 ms | 482.2181 ms |
| **DecodePlain** | **100000** |         **25** |     **557.452 ms** |   **9.9753 ms** |   **9.3309 ms** |
| EncodePlain | 100000 |         25 |   1,011.378 ms |   7.8383 ms |   6.9485 ms |
| **DecodePlain** | **100000** |        **100** |   **2,688.349 ms** |  **52.0043 ms** |  **53.4046 ms** |
| EncodePlain | 100000 |        100 |   7,574.555 ms |  65.1218 ms |  60.9150 ms |
| **DecodePlain** | **100000** |       **1024** |  **82,513.134 ms** | **878.9770 ms** | **779.1902 ms** |
| EncodePlain | 100000 |       1024 | 507,848.824 ms | 894.0934 ms | 836.3355 ms |

## Windows 10 & Intel Core i5-7400 CPU 3.00GHz (Kaby Lake) (v0.4.2)
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Intel Core i5-7400 CPU 3.00GHz (Kaby Lake), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=3.1.301
  [Host]     : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT


```
|      Method |      N | ByteLength |           Mean |         Error |        StdDev |
|------------ |------- |----------- |---------------:|--------------:|--------------:|
| **DecodePlain** |   **1000** |         **25** |       **4.193 ms** |     **0.0423 ms** |     **0.0396 ms** |
| EncodePlain |   1000 |         25 |       9.796 ms |     0.1933 ms |     0.2710 ms |
| **DecodePlain** |   **1000** |        **100** |      **23.995 ms** |     **0.4765 ms** |     **0.9066 ms** |
| EncodePlain |   1000 |        100 |      75.666 ms |     1.4982 ms |     2.9222 ms |
| **DecodePlain** |   **1000** |       **1024** |     **929.124 ms** |     **5.7647 ms** |     **4.8138 ms** |
| EncodePlain |   1000 |       1024 |   5,794.614 ms |    31.4779 ms |    29.4445 ms |
| **DecodePlain** |  **10000** |         **25** |      **46.030 ms** |     **0.9035 ms** |     **1.4844 ms** |
| EncodePlain |  10000 |         25 |      90.093 ms |     1.7852 ms |     3.8428 ms |
| **DecodePlain** |  **10000** |        **100** |     **242.119 ms** |     **4.8319 ms** |     **8.4627 ms** |
| EncodePlain |  10000 |        100 |     762.435 ms |    15.1747 ms |    26.9730 ms |
| **DecodePlain** |  **10000** |       **1024** |   **9,173.860 ms** |    **46.7766 ms** |    **39.0606 ms** |
| EncodePlain |  10000 |       1024 |  56,732.980 ms |    86.9217 ms |    72.5835 ms |
| **DecodePlain** | **100000** |         **25** |     **442.508 ms** |     **8.7553 ms** |    **13.8869 ms** |
| EncodePlain | 100000 |         25 |     924.538 ms |    17.9851 ms |    26.3624 ms |
| **DecodePlain** | **100000** |        **100** |   **2,385.195 ms** |    **12.8468 ms** |    **11.3883 ms** |
| EncodePlain | 100000 |        100 |   7,520.907 ms |    27.3458 ms |    25.5793 ms |
| **DecodePlain** | **100000** |       **1024** |  **93,009.584 ms** |   **242.9554 ms** |   **202.8788 ms** |
| EncodePlain | 100000 |       1024 | 571,634.067 ms | 2,743.5567 ms | 2,566.3247 ms |


## Windows 10 & Intel Core i5-7200U CPU 2.50GHz (Kaby Lake) (v0.4.2)
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.959 (1909/November2018Update/19H2)
Intel Core i5-7200U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.401
  [Host]     : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT


```
|      Method |      N | ByteLength |           Mean |         Error |        StdDev |         Median |
|------------ |------- |----------- |---------------:|--------------:|--------------:|---------------:|
| **DecodePlain** |   **1000** |         **25** |       **5.405 ms** |     **0.0965 ms** |     **0.0855 ms** |       **5.415 ms** |
| EncodePlain |   1000 |         25 |      10.934 ms |     0.2109 ms |     0.4013 ms |      10.752 ms |
| **DecodePlain** |   **1000** |        **100** |      **27.296 ms** |     **0.3133 ms** |     **0.2930 ms** |      **27.286 ms** |
| EncodePlain |   1000 |        100 |      84.386 ms |     3.1501 ms |     9.2881 ms |      88.762 ms |
| **DecodePlain** |   **1000** |       **1024** |     **886.472 ms** |    **14.1329 ms** |    **13.8804 ms** |     **882.492 ms** |
| EncodePlain |   1000 |       1024 |   5,895.664 ms |   113.4873 ms |   260.7559 ms |   5,957.617 ms |
| **DecodePlain** |  **10000** |         **25** |      **54.225 ms** |     **0.7272 ms** |     **0.6072 ms** |      **54.182 ms** |
| EncodePlain |  10000 |         25 |     105.913 ms |     1.2232 ms |     0.9550 ms |     105.855 ms |
| **DecodePlain** |  **10000** |        **100** |     **273.679 ms** |     **3.5092 ms** |     **4.3097 ms** |     **273.677 ms** |
| EncodePlain |  10000 |        100 |     833.539 ms |    29.6950 ms |    87.5565 ms |     888.051 ms |
| **DecodePlain** |  **10000** |       **1024** |   **9,033.943 ms** |   **175.1234 ms** |   **251.1568 ms** |   **8,969.433 ms** |
| EncodePlain |  10000 |       1024 |  57,966.312 ms |   957.4807 ms |   895.6280 ms |  58,012.295 ms |
| **DecodePlain** | **100000** |         **25** |     **530.699 ms** |     **8.2129 ms** |     **7.2805 ms** |     **531.107 ms** |
| EncodePlain | 100000 |         25 |   1,066.261 ms |    10.6483 ms |    10.4580 ms |   1,067.850 ms |
| **DecodePlain** | **100000** |        **100** |   **2,745.097 ms** |    **39.7939 ms** |    **31.0685 ms** |   **2,744.733 ms** |
| EncodePlain | 100000 |        100 |   8,079.527 ms |   160.6531 ms |   268.4152 ms |   8,046.803 ms |
| **DecodePlain** | **100000** |       **1024** |  **86,584.683 ms** | **1,700.7387 ms** | **1,670.3528 ms** |  **86,455.918 ms** |
| EncodePlain | 100000 |       1024 | 565,290.964 ms | 5,067.6686 ms | 4,492.3562 ms | 564,261.727 ms |










