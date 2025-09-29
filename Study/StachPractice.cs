namespace Practice.Study;

class StackPractice
{
    public void RunStackExample()
    {
        Console.WriteLine("---- Stucking practice (LIFO: Last in, frist out) ----");

        var history = new Stack<string>();

        Console.WriteLine("Add navigation history");
        history.Push("home pase");
        Console.WriteLine($"-> Pushed: {history.Peek()}");

        history.Push("Item pase");
        Console.WriteLine($"-> Pushed: {history.Peek()}");

        history.Push("Cart pase");
        Console.WriteLine($"-> Pushed: {history.Peek()}");

        Console.WriteLine($"Depth for current stack (element): {history.Count}");

        Console.WriteLine("\n--- Press the back button to go back in history ---");

        Console.WriteLine($"Pop: {history.Pop()}");

        Console.WriteLine($"Stack depth after pop: {history.Count}");
    }
}