using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionalsGradingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter grade as a number: ");
            string testScore = Console.ReadLine();
            int score = Convert.ToInt32(testScore);
            if (score <= 100 & score >= 93)
            {
                Console.WriteLine("You got an A, congrats");
            }
            else if (score <= 92 & score >= 90)
            {
                Console.WriteLine("You got a A-");
            }
            else if (score <= 89 & score >= 87)
            {
                Console.WriteLine("You got a B+");
            }
            else if (score <= 86 & score >= 83)
            {
                Console.WriteLine("You got a B");
            }
            else if (score <= 82 & score >= 80)
            {
                Console.WriteLine("You got a B-");
            }
            else if (score <= 79 & score >= 77)
            {
                Console.WriteLine("You got a C+");
            }
            else if (score <= 76 & score >= 73)
            {
                Console.WriteLine("You got a C");
            }
            else if (score <= 72 & score >= 70)
            {
                Console.WriteLine("You got a C-");
            }
            else if (score <= 69 & score >= 67)
            {
                Console.WriteLine("You got a D+");
            }
            else if (score <= 66 & score >= 63)
            {
                Console.WriteLine("You got a D");
            }
            else if (score <= 62 & score >= 60)
            {
                Console.WriteLine("You got a D-");
            }
            else if (score < 60)
            {
                Console.WriteLine("You got a E");
            }
        }
    }
}
