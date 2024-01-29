using System;

namespace uzd_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // get a number from the user (not less than 100) and store it in a variable
            Console.WriteLine("Enter a number (not less than 100):");
            int number = Convert.ToInt32(Console.ReadLine());
        
            // check if the number is higher than 100
            if (number < 100)
            {
                while (number < 100)
                {
                    Console.WriteLine("The number is less than 100");
                    Console.WriteLine("Enter a number (not less than 100):");
                    number = Convert.ToInt32(Console.ReadLine());
                }
            }

            // create a variable to store the sum
            int sum = 0;

            // loop through the cipari in the number
            for (int index = 0; index < number.ToString().Length; index++)
            {
                // get the cipars
                int cipars = Convert.ToInt32(number.ToString()[index].ToString());

                // add the cipars to the sum
                sum += cipars;
            }

            // print the sum
            Console.WriteLine("The sum of the digits in the number is {0}", sum);

        }
    }
}