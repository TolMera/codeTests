using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Fizzbuzz
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the start number:");
            int StartNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the finish number:");
            int FinishNumber = Convert.ToInt32(Console.ReadLine());

            int n = FinishNumber;

            if (FinishNumber >= StartNumber)
            {
                for (int i = StartNumber; i <= n; i++)
                {
                    String a = A(i);
                    Console.Write(a);
                }
            }
            else
            {
                for (int i = StartNumber; i >= n; i--)
                {
                    String a = A(i);
                    Console.Write(a);
                }
            }
        }

        private static string A(int num)
        {
            if (num % 3 == 0)
            {
                if (num % 5 == 0)
                {
                    return "Fizzbuzz" + " ";
                }
                else

                    return "Fizz" + " ";
            }

            else if (num % 5 == 0)

            {
                return "Buzz" + " ";
            }
            else
                return Convert.ToString(num) + " ";
        }
    }
}
