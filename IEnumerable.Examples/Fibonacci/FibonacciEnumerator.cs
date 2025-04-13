using System.Collections;

namespace IEnumerable.Examples.Fibonacci;

public class FibonacciEnumerator(int? max = null, int start = 0): IEnumerator<int>
{
    private int _position = start - 1;

    public bool MoveNext()
    {
        _position++;
        return max == null || _position <= max;
    }
    public void Reset() => _position = start - 1;
    public int Current => FibonacciCounter.CountValue(_position);

    object? IEnumerator.Current => Current;

    public void Dispose() => Reset();
}