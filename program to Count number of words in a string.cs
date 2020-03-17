///*
// * In this article, we will learn how to count number of words in a string. 

//This is a frequently asked interview question. Let’s look at the below C# implementation of this algorithm.
//*/

//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp1
//{
//    class program_to_Count_number_of_words_in_a_string
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Please enter string to be count:");
//            string input = Console.ReadLine();

//            int result = Count(input);

//            Console.WriteLine("Number of words in string: {0}", result);
//        }

//        public static int Count(string x)
//        {
//            int result = 0;

//            //Trim whitespace from beginning and end of string
//            x = x.Trim();

//            //Necessary because foreach will execute once with empty string returning 1
//            if (x == "")
//                return 0;

//            //Ensure there is only one space between each word in the passed string
//            while (x.Contains("  "))
//                x = x.Replace("  ", " ");

//            //Count the words
//            foreach (string y in x.Split(' '))
//                result++;

//            return result;
//        }
//    }
//}
