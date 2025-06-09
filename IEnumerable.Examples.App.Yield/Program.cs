using IEnumerable.Examples.Fibonacci.IEnumerables;

foreach (var element in FibonacciEnumerableYield.GetFibonacciEnumerable(40))
    Console.WriteLine(element);