using System.Threading.Tasks;
using BenchmarkDotNet.Running;

namespace RestaurantBenchmark;

public class Program
{
    public static async Task Main(string[] args)
    {
        var benchmarkSummary = BenchmarkRunner.Run<RestaurantDataBenchmark>();
    }
}