using IEnumerable.Examples.Fibonacci;

foreach (var element in FibonacciEnumerableYield.GetFibonacciEnumerable(40))
    Console.WriteLine(element);