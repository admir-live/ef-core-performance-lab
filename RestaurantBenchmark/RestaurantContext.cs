using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RestaurantBenchmark;

public sealed class RestaurantContext : DbContext
{
    public DbSet<MainDish> MainDishes { get; set; }
    public DbSet<SideDish> SideDishes { get; set; }
    public DbSet<Salad> Salads { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(Constants.ConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MainDish>().HasData(GenerateMainDishesSeedData());
        modelBuilder.Entity<SideDish>().HasData(GenerateSideDishesSeedData());
        modelBuilder.Entity<Salad>().HasData(GenerateSaladsSeedData());
    }

    private static IEnumerable<MainDish> GenerateMainDishesSeedData()
    {
        var mainDishesSeedData = new List<MainDish>();
        for (var dishId = 1; dishId <= Constants.MainDishesCount; dishId++)
            mainDishesSeedData.Add(new MainDish { Id = dishId, Name = $"Dish {dishId}" });
        return mainDishesSeedData;
    }

    private static IEnumerable<SideDish> GenerateSideDishesSeedData()
    {
        var sideDishesSeedData = new List<SideDish>();
        for (var sideDishId = 1; sideDishId <= Constants.SideDishesCount; sideDishId++)
            sideDishesSeedData.Add(new SideDish
            {
                Id = sideDishId, Name = $"Side {sideDishId}", MainDishId = sideDishId % Constants.MainDishesCount + 1
            });
        return sideDishesSeedData;
    }

    private static IEnumerable<Salad> GenerateSaladsSeedData()
    {
        var saladsSeedData = new List<Salad>();
        for (var saladId = 1; saladId <= Constants.SaladsCount; saladId++)
            saladsSeedData.Add(new Salad
                { Id = saladId, Name = $"Salad {saladId}", MainDishId = saladId % Constants.MainDishesCount + 1 });
        return saladsSeedData;
    }
}