using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedWhileLoopsCreateAProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int var = 0;
            while (var < 10)
            {
                int count = 9;
                while (count >= 0)
                {
                    Console.Write(var);
                    Console.WriteLine(count);
                    count = count - 1;
                } 
                var = var + 1;
            }           
        }
    }
}
