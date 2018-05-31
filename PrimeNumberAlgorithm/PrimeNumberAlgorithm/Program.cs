using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberAlgorithm
{
    class Program
    {
        //Check if a number is prime
        public static bool Chkprime(int num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }

        public static void Main()
        {
            Console.Write("\n\nFunction : To check a number is prime or not :\n");
            Console.Write("--------------------------------------------------\n");
            Console.Write("Input a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (Chkprime(n))
                Console.WriteLine(n + " is a prime number");
            else
                Console.WriteLine(n + " is not a prime number");

        }
    }
}
