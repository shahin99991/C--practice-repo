namespace Practice.Study;

public class EvenOddChecker
{
    public void Run()
    {
        Console.WriteLine("input the number");

        string? input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("This number is even number");
            }
            else
            {
                Console.WriteLine("This number is odd number");
            }
        }
        else
        {
            Console.WriteLine("invalid input, Please input the number");
        }
    }
}