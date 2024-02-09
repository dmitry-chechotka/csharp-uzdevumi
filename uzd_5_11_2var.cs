using System;

namespace uzd_5_11_2var
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask for a string and enter in in a variable
            string text;
            Console.WriteLine("Enter a string:");
            text = Console.ReadLine();

            // start a loop to check each character in the string
            for (int i = 0; i < text.Length; i++)
            {
                // check if the character is a pieturzīme
                if (text[i] == ',' or text[i] == '.' or text[i] == '!' or text[i] == '?' or text[i] == ':' or text[i] == ';' or text[i] == '-')
                {
                    // if it is, print out the position of the pieturzīme
                    Console.WriteLine("The character {0} is at position {1}", text[i], i);
                }

        }
    }
}