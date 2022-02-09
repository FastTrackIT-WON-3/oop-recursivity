using System;

namespace OopRecursivity
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 1, 2, 3, 4, 5 };
            int element = 3;
            int index = RecursivityHelper.IndexOfElement(element, array);
            Console.WriteLine($"Element {element} found at index: {index}");
        }

        private static void Example_Factorial()
        {
            int n = 5;
            int result = RecursivityHelper.Factorial(n);
            Console.WriteLine($"Fact({n})={result}");
        }

        private static void Example_Fibonacci()
        {
            /* n = 5 => 7 steps
             * n = 6 => 12 steps
             * n = 7 => 20 steps
             * n = 8 => 33 steps
             */
            int n = 8;
            long result = RecursivityHelper.Fibonacci(n);
            Console.WriteLine($"Fibonacci({n})={result}");
            Console.WriteLine($"Fibonacci({n}) calculated in {RecursivityHelper.FiboCallCount} steps");
        }
    }
}
