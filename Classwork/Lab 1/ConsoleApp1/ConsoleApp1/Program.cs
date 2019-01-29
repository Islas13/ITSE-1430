/*
 * Lab 1
 * Richard
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            NewGame();
            DisplayGame();
        }

        private static void NewGame()
        {
            // Writes to screen and adds line to end
            Console.WriteLine("Enter the name: ");
            // Grab value and store in a variable
            name = Console.ReadLine();

            //Console.WriteLine("Do you own this? ");
            //string owned = Console.ReadLine();
            owned = ReadBoolean("Owned (Y/N)?");

            //Console.WriteLine("Price? ");
            //string price = Console.ReadLine();
            price = ReadDecimal("Price?");

            Console.WriteLine("Publisher? ");
            publisher = Console.ReadLine();

            //Console.WriteLine("Completed? ");
            //string completed = Console.ReadLine();
            completed = ReadBoolean("Completed (Y/N)?");


        }

        private static void DisplayGame()
        {
            // A \ is an escape
            // \t will give a tab
            // \n will give a new line
            // \b sounds a beep
            // \x use for hex decimal
            // @ verbatim string, cannot use escapes while using
            string literal1 = "Hello \"Bob\" ";
            string path = "C:\\Windows\\System32";
            string path2 = @"C:\Windows\System32";

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Publisher: " + publisher);
            Console.WriteLine("Owned? " + owned);
            Console.WriteLine("Completed? " + completed);
        }
        private static bool ReadBoolean( string message )
        {
            Console.WriteLine(message);
            string result = Console.ReadLine();

            // Validate it is a boolean
            // TODO: Fix this expression
            // TODO shows up in the task list as it searches all files
            if (result == "Y")
                return true;
            if (result == "y")
                return true;
            if (result == "N")
                return false;
            if (result == "n")
                return false;

            // TODO: Add validation
            return false;
            
        }

        private static decimal ReadDecimal ( string message)
        {
            Console.WriteLine(message);
            string value = Console.ReadLine();

            // Decimal types have a parse funcion
            // Searches the string and brings forth the value
            // Int32.Parse  :   Double.Parse   :   Boolean.Parse
            decimal result;
            if (Decimal.TryParse(value, out result))
                return result;
            return 0;
        }

        private static string name;
        private static string publisher;
        private static decimal price;
        private static bool owned;
        private static bool completed;

    }

}
