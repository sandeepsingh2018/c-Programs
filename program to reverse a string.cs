/*
 In this article, we will learn how to reverse a string.
 
This is a frequently asked interview question.
 
Let’s look at the below C# implementation of this algorithm.

 */

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class program_to_reverse_a_string
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter string:");
            string input = Console.ReadLine();

            string result = Reverse(input);
            Console.WriteLine("reverse string: {0}", result);
        }


        //Reverse a string
        static string Reverse(string x)
        {
            string result = "";
            for (int i = x.Length - 1; i >= 0; i--)
                result += x[i];
            return result;
        }

    }
}
