namespace Practice.LeetCode;
class CountingExam
{
    public void HashMapSerch()
    {
        string[] words = { "apple", "banana", "apple", "orange", "banana", "apple" };

        var wordCount = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word] += 1;
            }
            else
            {
                wordCount.Add(word, 1);
            }
        }
        foreach (var pair in wordCount)
        {
            Console.WriteLine($"Word: {pair.Key}, Count:{pair.Value}");
        }

    }
}