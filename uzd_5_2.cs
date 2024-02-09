using System;

namespace uzd_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // get a string
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            bool currently_space = true;

            for (int index = 0; index < input.Length; index++)
            {
                if (currently_space == true):
                    if (input[index] == "a"):
                        for (int i = index; i < input.Length; i++)
                        {
                            if (input[i] == " "):
                                currently_space = true;
                            else:
                                currently_space = false;
                        }
                        
                if (input[index] == " "):
                    currently_space = true;

                

            }
        }
    }
}