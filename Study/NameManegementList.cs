namespace Practice.Study;

class NameManegementList
{
    public void RunListExample()
    {
        List<string> names = new List<string>();

        names.Add("Tanaka");
        names.Add("Satou");
        names.Add("Yamada");
        names.Add("Suzuki");

        Console.WriteLine("--- state of initial List ---");
        Console.WriteLine($"Number of element in the List now: {names.Count}");

        Console.WriteLine("[All element in the List]");

        foreach (string name in names)
        {
            Console.WriteLine($"- {name}");
        }
        string nameToRemove = "Tanaka";
        if (names.Remove(nameToRemove))
        {
            Console.WriteLine($"{nameToRemove} Remove to List");
        }
        else
        {
            Console.WriteLine($"{nameToRemove} Not Fund name");
        }

        Console.WriteLine("\n--- List State after Remove name ---");
        Console.WriteLine($"Number of element int List now{names.Count}");
        Console.WriteLine("[Remaining elements  after the deletion]");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}