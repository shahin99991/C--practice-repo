namespace Practice.Study;
class CountingEvenOdd
{
    public void CountNumber()
    {
        int evenCount = 0;

        int oddCount = 0;

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }
        Console.WriteLine("Judgment result from 1 to 100");
        Console.WriteLine(evenCount);
        Console.WriteLine(oddCount);

    }
}