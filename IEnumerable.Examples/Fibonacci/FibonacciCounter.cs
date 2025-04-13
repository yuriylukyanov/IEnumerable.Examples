namespace IEnumerable.Examples.Fibonacci;

internal static class FibonacciCounter
{
    internal static int CountValue(int x)
    {
        int k = x switch
        {
            >= 0 => x switch
            {
                0 => 0,
                1 => 1,
                2 => 1,
                _ => CountValue(x - 1) + CountValue(x - 2)
            },
            _ => x switch
            {
                -1 => 1,
                -2 => -1,
                _ => CountValue(x + 2) - CountValue(x + 1)
            }
        };

        return k;
    }
}