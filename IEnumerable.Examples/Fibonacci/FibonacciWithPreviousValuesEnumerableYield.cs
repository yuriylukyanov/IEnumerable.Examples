namespace IEnumerable.Examples.Fibonacci;

public static class FibonacciWithPreviousValuesEnumerableYield
{
    public static IEnumerable<long> GetFibonacciEnumerable(long? max = null)
    {
        var position = 0;
        var previousValue = default(long?);
        var prePreviousValue = default(long?);
        do
        {
            var value = FibonacciWithPreviousValuesCounter.CountValue(position, previousValue, prePreviousValue);
            prePreviousValue = previousValue;
            previousValue = value;
            yield return value;
            position++;
        } 
        while (max is null || max >= position);
    }
}