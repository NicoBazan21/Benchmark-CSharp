using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

namespace Benchmark_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Summary[] summary = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}
