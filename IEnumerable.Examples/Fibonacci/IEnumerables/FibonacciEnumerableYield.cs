using IEnumerable.Examples.Fibonacci.Counters;

namespace IEnumerable.Examples.Fibonacci.IEnumerables;

public static class FibonacciEnumerableYield
{
    public static IEnumerable<int> GetFibonacciEnumerable(int? max = null, int start = 0)
    {
        var position = start;
        do
        {
            yield return FibonacciCounter.CountValue(position);
            position++;
        } 
        while (max is null || max >= position);
    }
}