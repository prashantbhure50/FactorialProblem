using System;

namespace FactorialProblem
{
    class Program
    {
        static  void Factorial (int number)
        {
            int sum = 1;
            for (int i = number; i > 0; i--)
            {
                sum = sum * i;
            }
            Console.WriteLine("Factorial using normal method - "+sum);
        }

        public static long RecursionFactorial(int number)
        {
            if (number == 0)
                return 1;
            else
                return number * RecursionFactorial( number - 1);


        }
        static void Main(string[] args)
        {
            long Total = 1;
            Console.WriteLine("Enter a number");
            int sum = Convert.ToInt32(Console.ReadLine());
            Factorial(sum);
            Total=RecursionFactorial(sum);
            Console.WriteLine("Factorial using recursion - " + Total);
           
        }
    }
}
