# Main benchmark
## Windows 10 & Intel Core i7-6700K CPU 4.00GHz (Skylake)
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

## ubuntu 16.04 & Intel Core i7-2600 CPU 3.40GHz (Sandy Bridge)
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

## Windows 10 & Intel Core i5-7400 CPU 3.00GHz (Kaby Lake)
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


## Windows 10 & Intel Core i5-7200U CPU 2.50GHz (Kaby Lake)
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










