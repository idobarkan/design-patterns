using System;
using System.Collections.Generic;
using System.Text;

namespace _17_Command
{
    /// <summary>
    ///  The 'after' demonstrates the classic implementation of the command pattern
    ///  and makes the menu mechanism:
    ///  a. Reusable (one can use the menu mechanism in a differnt program)
    ///  b. Efficient (no need to go through a switch-case for each selection. just executing the selected command)
    ///  c. Easy to maintain (in case of adding/removing menu items, we will only need to add/remove menu items)
    ///  d. Not coupled with the client of the menu mechanism (the menu mechanism does not "know" the client and has no direct access to it's methods)
    /// </summary>
    public class After
    {
        public static void Run()
        {
            After after = new After();
            after.InitMenu();
            after.Execute();
        }

        Menu m_Menu;
        public void InitMenu()
        {
            m_Menu = new Menu()
            {
                new MenuItem{Text = "Print Hello", Command = new PrintHelloCommand{Client = this}},
                new MenuItem { Text = "Print Date", Command = new PrintDateCommand{ Client = this }},
                new MenuItem { Text = "Print Time", Command = new PrintTimeCommand { Client = this }}
            };
        }

        public void Execute()
        {
            m_Menu.Run();
        }

        private void PrintHello()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello!!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void PrintTheDate()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void PrintTheTime()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.ForegroundColor = ConsoleColor.White;
        }

        public class PrintHelloCommand : ICommand
        {
            public After Client { get; set; }

            public void Execute()
            {
                Client.PrintHello();
            }
        }

        public class PrintDateCommand : ICommand
        {
            public After Client { get; set; }

            public void Execute()
            {
                Client.PrintTheDate();
            }
        }

        public class PrintTimeCommand : ICommand
        {
            public After Client { get; set; }

            public void Execute()
            {
                Client.PrintTheTime();
            }
        }
    }

    public interface ICommand
    {
        void Execute();
    }

    public class MenuItem
    {
        public ICommand Command { get; set; }
        public string Text { get; set;}

        public virtual void Selected()
        {
            if (Command != null)
            {
                Command.Execute();
            }
        }
    }

    public class Menu : List<MenuItem>
    {
        public void Run()
        {
            bool userQuit = false;
            int userSelection;
            while (!userQuit)
            {
                ShowMenu();
                try
                {
                    userQuit = !GetUserSelection(out userSelection);
                    if (!userQuit)
                    {
                        Console.Clear();
                        this[userSelection - 1].Selected();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private bool GetUserSelection(out int o_UserSelection)
        {
            bool userQuit = false;
            string userSelection = Console.ReadLine();
            if (userSelection.ToLower() != "q")
            {
                o_UserSelection = int.Parse(userSelection);
                if (!(o_UserSelection > 0 && o_UserSelection <= this.Count))
                {
                    throw new ArgumentException(string.Format("You must select a number between 1-{0}", this.Count));
                }
            }
            else
            {
                o_UserSelection = 0;
                userQuit = true;
            }

            return !userQuit;
        }

        private void ShowMenu()
        {
            Console.WriteLine("Please choose:");

            int itemNum = 1;
            foreach (MenuItem item in this)
            {
                Console.Write(itemNum.ToString() + ": ");
                Console.WriteLine(item.Text);
                itemNum++;
            }

            Console.WriteLine(@"
Type your selection number and press 'enter'.
To quit type 'Q' and then 'enter'
");
        }
    }
}
