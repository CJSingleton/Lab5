using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSingleton_Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            long f;
            string input = "y";

            while (input == "y")
            {
                Console.WriteLine("Please enter a number between 1 and 25:");
                n = int.Parse(Console.ReadLine());
                f = n;

                if (n == 0)
                {
                    n = n + 1;
                }

                for (i = n - 1; i >= 1; i--) // multiplying by 0 would break the factorial, so it isn't included 
                                             // as a number to multiply by in the loop.
                {
                    f *= i;// another way of writing f = f * i
                }

                Console.WriteLine(f);

                Console.WriteLine("Would you like to continue (y/n)");
                input = (Console.ReadLine()).ToLower();

            }
        }
    }
}
