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

            while (input == "y")//For program exit procedure.
            {
                Console.WriteLine("Please enter a number between 0 and 25:");//original requirement was for 1-10, but some modifications have been made to the code.
                n = int.Parse(Console.ReadLine());
                f = n;

                if (f == 0)//having this here ensures that the user can input 0 and still get an accurate factorial.
                {
                    f = f + 1;
                }

                for (i = n - 1; i >= 1; i--) // Multiplying by 0 would break the factorial, so it isn't included 
                                             // as a number to multiply by in the loop.
                {
                    f *= i;// ...other way of writing f = f * i
                }

                Console.WriteLine(f);

                Console.WriteLine("Would you like to continue (y/n)");
                input = (Console.ReadLine()).ToLower();

            }
        }
    }
}
