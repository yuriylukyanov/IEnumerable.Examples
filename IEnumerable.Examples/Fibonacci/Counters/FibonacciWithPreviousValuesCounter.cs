namespace IEnumerable.Examples.Fibonacci.Counters;

internal static class FibonacciWithPreviousValuesCounter
{
    internal static long CountValue(long x, long? previousValue = null, long? prePreviousValue = null)
    {
        var k = x switch
        {
            >= 0 => x switch
            {
                0 => 0,
                1 => 1,
                2 => 1,
                _ => checked(previousValue.GetValueOrDefault() + prePreviousValue.GetValueOrDefault())
            },
            _ => x switch
            {
                -1 => 1,
                -2 => -1,
                _ => checked(previousValue.GetValueOrDefault() - prePreviousValue.GetValueOrDefault())
            }
        };

        return k;
    }
}