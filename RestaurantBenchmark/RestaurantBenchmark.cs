using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Microsoft.EntityFrameworkCore;

namespace RestaurantBenchmark;

[MemoryDiagnoser]
public class RestaurantDataBenchmark
{
    private RestaurantContext _restaurantDbContext;

    [GlobalSetup]
    public async Task InitializeDatabaseAsync()
    {
        _restaurantDbContext = new RestaurantContext();
        await _restaurantDbContext.Database.EnsureCreatedAsync();
    }

    [Benchmark]
    public async Task RetrieveMainDishesWithRelatedEntitiesAsync()
    {
        await _restaurantDbContext.MainDishes
            .Include(course => course.Salads)
            .Include(course => course.SideDishes)
            .ToListAsync();
    }

    [Benchmark]
    public async Task RetrieveMainDishesWithSplitQueryOptimizationAsync()
    {
        await _restaurantDbContext.MainDishes
            .Include(course => course.Salads)
            .Include(course => course.SideDishes)
            .AsSplitQuery()
            .ToListAsync();
    }

    [GlobalCleanup]
    public void DisposeDbContext()
    {
        _restaurantDbContext.Dispose();
    }
}