namespace Practice.Study;

class QueuePractice
{
    public void RunQueueExample()
    {
        Console.WriteLine("\nPractice Queue (FIFO: frist in, last out)");

        var supportQueue = new Queue<string>();

        Console.WriteLine("Add a query to the queue:");
        supportQueue.Enqueue("Customer A");
        supportQueue.Enqueue("Customer B");
        supportQueue.Enqueue("Customer C");

        Console.WriteLine($"Current queue length: {supportQueue.Count}");

        Console.WriteLine($"Peel: The next things to be processed is {supportQueue.Peek()}.");
        Console.WriteLine($"Dequeue: Completed the response to{supportQueue.Dequeue()}");
        Console.WriteLine($"Dequeue: Completed the response to{supportQueue.Dequeue()}");

        Console.WriteLine($"Current queue length after response: {supportQueue.Count}");

    }
}