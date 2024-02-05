using System;

namespace uzd_5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";

            Console.WriteLine(script[0, 8].ToUpper() + script[8, ]);
        }
    }
}