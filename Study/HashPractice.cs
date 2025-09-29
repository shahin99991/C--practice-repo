namespace Practice.Study;
class HashPractice
{
    public void Run()
    {
        Console.WriteLine("--- Dictionary. Modern way to HashMap ---");

        var items = new Dictionary<int, string>
        {
            { 500, "Banana"},
            { 100, "Apple"},
            { 800, "Orange"},
            { 200, "Grape"},
        };
        Console.WriteLine($"search for 100Yen items: {items[100]}");

        foreach (var pair in items)
        {
            //.key .value
            Console.WriteLine($"price:{pair.Key}, items: {pair.Value}");
            
        }
    }

}