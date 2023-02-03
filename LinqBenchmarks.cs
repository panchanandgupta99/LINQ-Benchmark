using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace POC.LinqBenchmarks
{
    [SimpleJob(RuntimeMoniker.Net60)]
    [SimpleJob(RuntimeMoniker.Net70)]
    [MemoryDiagnoser(false)]
    public class LinqBenchmarks
    {
        [Params(100)]
        public int size { get; set; }
        private IEnumerable<int> items = null!;

        [GlobalSetup]
        public void Setup()
        {
            items = Enumerable.Range(1, size).ToArray();
        }

        [Benchmark]
        public int Min() => items.Min();

        [Benchmark]
        public int Max() => items.Max();

        [Benchmark]
        public double Avg() => items.Average();

        [Benchmark]
        public int Sum() => items.Sum();
    }
}
