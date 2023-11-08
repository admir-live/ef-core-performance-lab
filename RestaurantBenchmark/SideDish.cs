namespace RestaurantBenchmark;

public class SideDish
{
    public int Id { get; init; }
    public string Name { get; init; }
    public int MainDishId { get; init; }
    public MainDish MainDish { get; init; }
}