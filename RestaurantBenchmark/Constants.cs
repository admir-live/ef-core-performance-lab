namespace RestaurantBenchmark;

public static class Constants
{
    public const string ConnectionString =
        @"Server=.,1434;Database=RestaurantDB;User Id=sa;Password=1Strong#Pwd;MultipleActiveResultSets=True;TrustServerCertificate=True;Encrypt=false";

    public const int MainDishesCount = 10000;
    public const int SideDishesCount = 20000;
    public const int SaladsCount = 20000;
}