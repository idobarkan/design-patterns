using System;
using System.Collections.Generic;
using System.Text;

namespace _03_StaticFactoryClass
{
    public class After
    {
        internal static void Run()
        {
            bool stillRuning = true;
            do
            {
                Console.Write("Please enter your full name: ");
                string fullName = Console.ReadLine();

                // using the factory to get the appropriate namer:
                FullName namer = FullNameFactory.Create(fullName);

                // polymorphically using the concrete namer:
                Console.WriteLine("First Name: {0}, Last Name: {1}",
                    namer.FirstName, namer.LastName);

                Console.WriteLine("Would you like to try again? (Y/N)");
                stillRuning = Console.ReadLine().ToLower() == "y";

            } while (stillRuning);
        }


        /// <summary>
        /// This is our factory class
        /// </summary>
        public static class FullNameFactory
        {
            public static FullName Create(string i_FullName)
            {
                /// NOTE:
                /// This code could be easily replaced with
                /// a code that reads a configuration file
                /// which holds inforamtion (that can be updated/modified)
                /// regarding which instance to create in respect to i_FullName
                
                int i = i_FullName.IndexOf(",");
                if (i > 0)
                {
                    return new FullName_En_US(i_FullName);
                }
                else
                {
                    return new FullName_He_IL(i_FullName);
                }
            }
        }
    }
}
