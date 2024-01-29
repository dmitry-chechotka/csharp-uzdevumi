using System;

namespace uzd_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You have 20 emails in your inbox");
            Console.WriteLine("Deleting emails...\n");

            for (int emails = 20; emails != 0; emails--)
            {
                Console.WriteLine("One email deleted, {0} emails left", emails - 1);
            }

            Console.WriteLine("All emails deleted");
        }
    }
}