namespace Tutorial_LINQ;

internal class QuantifierOperations
{
    public void Run()
    {
        var Markets = new[]
        {
            new { MarketName = "Market A", Fruits = new string[] { "kiwi", "cherry", "banana" } },
            new { MarketName = "Market B", Fruits = new string[] { "melon", "mango", "olive" } },
            new { MarketName = "Market C", Fruits = new string[] { "kiwi", "apple", "orange" } },
        };


        Console.WriteLine("All 사용**************************************");
        var query = from market in Markets
                    where market.Fruits.All(fruit => fruit.Length == 5)
                    select market.MarketName;
        Print(query);


        Console.WriteLine("Any 사용**************************************");
        query = from market in Markets
            where market.Fruits.Any(fruit => fruit.StartsWith("o"))
            select market.MarketName;
        Print(query);

        Console.WriteLine("Contains 사용**************************************");
        query = from market in Markets
            where market.Fruits.Contains("kiwi")
            select market.MarketName;
        Print(query);

        Console.ReadKey();

    }

    private void Print(IEnumerable<string> query)
    {
        foreach (var market in query)
        {
            Console.WriteLine(market);
        }

        Console.WriteLine();
    }
}
