using System;

namespace uzd_5_11_1var
{
    class Program
    {
        // Programma atrisina problēmu, izmantojot virknes, kas attēlotas ka simbolu masīvi.

        static void Main(string[] args)
        {
            // ask for a string and enter in in a variable
            string text;
            Console.WriteLine("Enter a string:");
            text = Console.ReadLine();

            // turn the string into a character array
            char[] textArray = text.ToCharArray();

            // start a loop to check each character in the string
            for (int i = 0; i < textArray.Length; i++)
            {
                // check if the character is a pieturzīme
                if (textArray[i] == ',' || textArray[i] == '.' || textArray[i] == '!' || textArray[i] == '?' || textArray[i] == ':' || textArray[i] == ';' || textArray[i] == '-')
                {
                    // if it is, print out the position of the pieturzīme
                    Console.WriteLine("The character {0} is at position {1}", textArray[i], i);
                }

        }
    }
}