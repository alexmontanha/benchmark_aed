using System.Diagnostics;

namespace Benchmark;

static class Program
{
    static void Main()
    {
        var list = new List<int>(Enumerable.Range(0, 1000000));
        var linkedList = new LinkedList<int>(list);

        Stopwatch stopwatch = new Stopwatch();

        // Benchmark para List com for
        stopwatch.Start();
        for (int i = 0; i < list.Count; i++)
        {
            var _ = list[i];
        }
        stopwatch.Stop();
        Console.WriteLine($"Tempo para List com for: {stopwatch.ElapsedMilliseconds} ms");
        stopwatch.Reset();

        // Benchmark para List com foreach
        stopwatch.Start();
        foreach (var _ in list)
        {
        }
        stopwatch.Stop();
        Console.WriteLine($"Tempo para List com foreach: {stopwatch.ElapsedMilliseconds} ms");
        stopwatch.Reset();

        // Benchmark para List com expressão lambda
        stopwatch.Start();
        list.ForEach(_ => { });
        stopwatch.Stop();
        Console.WriteLine($"Tempo para List com expressão lambda: {stopwatch.ElapsedMilliseconds} ms");
        stopwatch.Reset();

        // Benchmark para LinkedList com foreach
        stopwatch.Start();
        foreach (var _ in linkedList)
        {
        }
        stopwatch.Stop();
        Console.WriteLine($"Tempo para LinkedList com foreach: {stopwatch.ElapsedMilliseconds} ms");
        stopwatch.Reset();

        // Benchmark para LinkedList com expressão lambda
        stopwatch.Start();
        linkedList.ToList().ForEach(_ => { });
        stopwatch.Stop();
        Console.WriteLine($"Tempo para LinkedList com expressão lambda: {stopwatch.ElapsedMilliseconds} ms");
    }
}