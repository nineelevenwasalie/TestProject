﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syntaxDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 7;
            int var2 = 12;
            string myString = "Frank";
            if (var1 < 10)
            {
                var2 = 9;
            }
            if (myString == "frank")
            {
            }
            else
            {
                myString = "Turtles";
            }
            if (var1 > var2)
            {
                var1 = var1 = 2;
                var2 = 13;
            }
            else if (var2 == var1)
            {
                var1 = var1 + 1;
                var2 = 14;
            }
            else
            {
                var2 = 11;
            }
            if (var1 <= 12)
            {

                if (var2 >= var1)
                {
                    var2 = 11;
                }
            }
            else if (var2 >= var1)
            {
                var2 = var1 + 3;
            }
            else
            {
                var2 = 1337;
            }
            if (var1 > 12)
            {
                var2 = var1 - var2;
                var1 = 71;
            }
            else
            {
                var1 = 123;
            }
            if (var1 == 12)
            {
                var1 = 12;
            }
        }
    }
}