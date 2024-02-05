using System;

namespace uzd_5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string password
            Console.WriteLine("Enter a password:");
            password = Console.ReadLine();

            int passwordLength = password.Length;

            bool passwordCheck

            // check if the password contains !
            if (password.Contains("!"))
            {
                passwordCheck = true;
            }
            else
            {
                passwordCheck = false;
            }

            Console.WriteLine("The user password is {0}. Its length is {1} and it receives a {2} check", password, passwordLength, passwordCheck);

        }
    }
}