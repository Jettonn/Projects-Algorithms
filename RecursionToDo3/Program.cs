using System;

namespace RecursionToDo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 3, 5, 6 };
            // Console.WriteLine("Recursive Binary Search: Check if [1,3,5,6] contains 4: {0}", rBinarySearch(array, 4));

            int a = 123456, b = 987654;
            Console.WriteLine("GCD of " + a + " and " + b + " is " + rGCF(a, b));
        }

        static bool rBinarySearch(int[] array, int value)
        {
            return BinarySearch(array, value, 0);
        }
        static bool BinarySearch(int[] array, int value, int i)
        {
            bool hasValue = false;
            if (array.Length > i)
            {
                if (array[i] == value)
                    hasValue = true;
                else
                    hasValue = BinarySearch(array, value, i + 1);
            }
            return hasValue;
        }

        static int rGCF(int num1, int num2)
        {
            if (num2 == 0)
                return num1;

            if (num1 == num2)
                return num1;

            return rGCF(num2, num1 % num2);
        }
    }
}
