using System;

namespace RecursionToDo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recursive Sigma: Sum of n numbers: " + rSigma(6));
            Console.WriteLine("Recursive Factorial: Products of n numbers: " + rFact(6));
        }

        static int rSigma(double n)
        {
            int number = (int)n;
            if (number <= 0)
                return 0;
            if (number == 1)
                return 1;
            return number + rSigma(number - 1);
        }

        static int rFact(double n)
        {
            int number = (int)n;
            if (number == 0)
                return 1;
            return number * rFact(n - 1);
        }
    }
}
