using IEnumerable.Examples.Fibonacci.IEnumerables;

var parameterIndex = 0;
foreach (var element in FibonacciWithPreviousValuesEnumerableYield.GetFibonacciEnumerable(100))
{
    Console.WriteLine($"{parameterIndex}: {element}");
    parameterIndex++;
}