using System;
using System.Collections.Generic;
using System.Text;

namespace _02_StaticFactoryMethod
{
    public class After
    {
        internal static void Run()
        {
            bool stillRuning = true;
            do
            {
                Console.Write("Please enter your full name: ");
                string fullNameString = Console.ReadLine();

                // using the base class to get the appropriate concrete:
                FullName fullName = FullName.Create(fullNameString);

                // polymorphically using the concrete namer:
                Console.WriteLine("First Name: {0}, Last Name: {1}",
                    fullName.FirstName, fullName.LastName);

                Console.WriteLine("Would you like to try again? (Y/N)");
                stillRuning = Console.ReadLine().ToLower() == "y";

            } while (stillRuning);
        }
    }
}
