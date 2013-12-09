using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace _03_StaticFactoryClass
{
    public class Before
    {
        internal static void Run()
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

    public abstract class FullName
    {
        protected string m_FirstName;
        public string FirstName
        {
            get { return m_FirstName; }
            set { m_FirstName = value; }
        }

        protected string m_LastName;
        public string LastName
        {
            get { return m_LastName; }
            set { m_LastName = value; }
        }
    }
}
