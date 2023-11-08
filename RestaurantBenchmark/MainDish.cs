using System.Collections.Generic;

namespace RestaurantBenchmark;

public class MainDish
{
    public int Id { get; init; }
    public string Name { get; init; }
    public List<SideDish> SideDishes { get; init; }
    public List<Salad> Salads { get; init; }
}