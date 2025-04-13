// See https://aka.ms/new-console-template for more information

using IEnumerable.Examples.Fibonacci;

var fibonacciEnumerable = new FibonacciEnumerable(10);

foreach (var element in fibonacciEnumerable)
    Console.WriteLine(element);
Console.Clear();

foreach (var element in FibonacciEnumerableYield.GetFibonacciEnumerable(10))
    Console.WriteLine(element);
    
    