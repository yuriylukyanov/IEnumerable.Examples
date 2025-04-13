using System.Collections;

namespace IEnumerable.Examples.Fibonacci;

public class FibonacciEnumerable(int? max = null, int start = 0): IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator() => new FibonacciEnumerator(max, start);

    IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
}