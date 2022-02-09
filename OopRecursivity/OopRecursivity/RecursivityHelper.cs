using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopRecursivity
{
    public static class RecursivityHelper
    {
        internal static int FiboCallCount = 0;
        private static long[] FiboCache = new long[1000];


        public static int Factorial(int n)
        {
            if (n ==1 || n == 0)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }

        public static void PrintArray(int[] array)
        {
            if (array is null || array.Length == 0)
            {
                return;
            }

            PrintArray(array, 0);
        }

        private static void PrintArray(int[] array, int index)
        {
            Console.Write(array[index]);

            if (index < array.Length - 1)
            {
                Console.Write(", ");
                PrintArray(array, index + 1);
            }
        }

        public static long Fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }

            if (FiboCache[n] > 0)
            {
                return FiboCache[n];
            }

            FiboCallCount++;
            long result = Fibonacci(n - 1) + Fibonacci(n - 2);
            FiboCache[n] = result;
            return result;
        }

        public static int IndexOfElement(int element, int[] array)
        {
            return IndexOfElement(element, array, 0, array.Length - 1);
        }

        private static int IndexOfElement(int element, int[] array, int indexStart, int indexEnd)
        {
            if (indexStart >= array.Length || indexEnd < 0)
            {
                return -1;
            }

            int middleIndex = (indexStart + indexEnd) / 2;

            if (element == array[middleIndex])
            {
                return middleIndex;
            }
            else if(element < array[middleIndex])
            {
                // we need to search in the left sub-array
                return IndexOfElement(element, array, indexStart, middleIndex - 1);
            }
            else
            {
                // we need to search in the right sub-array
                return IndexOfElement(element, array, middleIndex + 1, indexEnd);
            }
        }
    }
}
