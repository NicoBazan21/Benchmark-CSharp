``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.17763.2803 (1809/October2018Update/Redstone5)
AMD A8-3800 APU with Radeon(tm) HD Graphics, 1 CPU, 4 logical and 4 physical cores
Frequency=14318180 Hz, Resolution=69.8413 ns, Timer=HPET
.NET SDK=8.0.100
  [Host]     : .NET 5.0.15 (5.0.1522.11506), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 5.0.15 (5.0.1522.11506), X64 RyuJIT


```
|                    Method |     Mean |     Error |    StdDev |
|-------------------------- |---------:|----------:|----------:|
|       ConcatStrIgualacion | 6.866 μs | 0.0598 μs | 0.0531 μs |
| ConcatStrConStrBdlrAppend | 1.850 μs | 0.0076 μs | 0.0063 μs |
|           ConcatStrConcat | 1.084 μs | 0.0017 μs | 0.0014 μs |
