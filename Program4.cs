//Remove Duplicate characters from String in C#
/*
In this article, we will discuss how to remove duplicate characters from string.
The string may have two or more same characters in it but we want it to have only one. So let’s look at an example to understand it better.

Required input and output
Input: Csharpstar
Output: Csharpt

Input: Google
Output: Gogle

Input: Yahoo
Output: Yaho

Input: CNN
Output: CN

 

Simple way of Implementation:
The essential logic in removing duplicate characters is to check all the chars that have been encountered and avoid adding further characters that have been encountered already.
*/
using System;

class Program3
{
    static void Main()
    {
        Console.WriteLine("Please provide the sting:");
        string input = Console.ReadLine();

        string resultString = RemoveDuplicateChars(input);

        Console.WriteLine("Result: {0}", resultString);

    }

    static string RemoveDuplicateChars(string key)
    {
        string result = "";
        string table = "";
        foreach (var item in key)
        {
            if(table.IndexOf(item) == -1)
            {
                table = table + item;
                result = result + item;
                
            }
        }
        return result;
    }
}

