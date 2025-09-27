namespace Practice.Study;

class SumOfTheNumbers
{
    public void CalculateSume()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine($"Length{numbers.Length}");
        Console.WriteLine($"Sum Of The Numbers: {sum}");
    }
}