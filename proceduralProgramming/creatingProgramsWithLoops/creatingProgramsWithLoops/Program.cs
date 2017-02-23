using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creatingProgramsWithLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i =1; i<=100; i = i + 1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            for (int e =2; e<=100; e = e + 2)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine();

            for (int o =1; o<=99; o = o + 2)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine();

            for (int w = 5; w<=80; w = w + 1)
            {
                Console.WriteLine(w);
            }

            Console.WriteLine();

            for (int d = 50; d>=5; d = d - 1)
            {
                Console.WriteLine(d);
            }

            Console.WriteLine();

            Console.WriteLine("Please enter a number: ");
            Console.WriteLine();
            string userInput = Console.ReadLine();
            int value1 = Convert.ToInt32(userInput);
            Console.WriteLine("Please enter another number: ");
            Console.WriteLine();
            string userInput1 = Console.ReadLine();
            int value2 = Convert.ToInt32(userInput1);
            int a = value1;
            int b = value2;
            while (a <= b)
            {
                Console.WriteLine(a);
                a = a + 1;
            }
                    while (a >= b)
                    {
                        Console.WriteLine(a);
                        a = a - 1;
                    }

            Console.WriteLine();

            for (int z = 1; z>=10; z = z + 1)
            {
                Console.WriteLine(z + "I counted to 10, 1 time(s)");
                if (z == 10)
                {

                }
            }
        }
    }
}
