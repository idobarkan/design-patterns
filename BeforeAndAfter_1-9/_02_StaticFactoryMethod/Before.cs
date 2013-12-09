using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace _02_StaticFactoryMethod
{
    public class Before
    {
        public static void Run()
        {
            bool stillRuning = true;
            do
            {
                Console.Write("Please enter your full name: ");
                string fullName = Console.ReadLine();

                FullName namer;
                int i = fullName.IndexOf(",");
                if (i > 0)
                {
                    namer = new FullName_En_US(fullName);
                }
                else
                {
                    namer = new FullName_He_IL(fullName);
                }

                // polymorphically using the concrete namer:
                Console.WriteLine("First Name: {0}, Last Name: {1}",
                    namer.FirstName, namer.LastName);

                Console.WriteLine("Would you like to try again? (Y/N)");
                stillRuning = Console.ReadLine().ToLower() == "y";

            } while (stillRuning);
        }  
    }
}
