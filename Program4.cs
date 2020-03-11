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

