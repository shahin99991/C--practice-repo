namespace Practice.Study;

class MultiplicationTabel
{
    public void MultiplicationTable()
    {
        Console.WriteLine("--- 9x9 Multiplication table ---");

        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                int product = i * j;

                Console.WriteLine($"{product, 3}");
            }
            Console.WriteLine();
        }
    }
}