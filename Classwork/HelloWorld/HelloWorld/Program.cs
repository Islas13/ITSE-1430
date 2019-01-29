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
            var literal1 = "Hello \"Bob\" ";   // var is type inferencing, changes type due to how it is utilized
            var path = "C:\\Windows\\System32";  // Compiler will determine the type itself instead of need specification
            string path2 = @"C:\Windows\System32";
            var i = 10;

            // 1. String concat
            Console.WriteLine("Name: " + name);

            // 2. String Format
            string str = String.Format("Price: {0:C}", price);   // :C used in parameter to format into currency
            Console.WriteLine(str);
            //Console.WriteLine("Price: " + price);    Same as above

            // 3. Function Overload - Just calls string format
            Console.WriteLine("Publisher: {0}" + publisher);

            // 4. Concatenation
            str = String.Concat("Owned?", " ", owned);
            Console.WriteLine(str);
            //Console.WriteLine("Owned? " + owned);   Same as above

            // 5. Interpolation
            Console.WriteLine($"Completed? {completed}");   // Using the $ will cause interpolation and will look for curly braces
            //Console.WriteLine("Completed? " + completed);  Same as above

            // Convert to a string
            string strPrice = price.ToString("C");
            string strLiteral = "Hello".ToString();
            // ReadBoolean("Hello").ToString();
            10.ToString();  //  "10"

            // Is string empty
            string input = null;
            int length = input.Length;
            bool isEmpty;

            // 1.)
            //if (input != null)
            //    isEmpty = input.Length == 0;
            //else
            //    isEmpty = true;

            // Conditional Operator is identical as above
            // 2.)
            isEmpty = (input != null) ? input.Length == 0 : true;  // If input is not null then show length else it is true
            
            // 3.)
            isEmpty = input == "";
            
            // 4.)
            isEmpty = input == String.Empty;   // Same as both above

            // 5.)
            isEmpty = String.IsNullOrEmpty(input);   // Gives a bool
            // .IsNullorWhiteSpace shows if it has spaces or not

            // Comparison
            bool areEqual = "Hello" == "hello";
            areEqual = String.Compare("Hello", "hello", true) == 0;  // 3rd parameter makes it case sensitive

            // Conversion
            input = input.ToUpper();
            input = input.ToLower();

            // Manipulation  -  Case sensitive parsing that returns booleans
            bool startsWith = input.StartsWith("http:");
            bool endsWith = input.EndsWith("/");

            // Strips off whitespace
            input = input.TrimStart();
            input = input.TrimEnd();
            input = input.Trim();

            // Used for making tables and adds white space 
            input = input.PadLeft(10);
            input = input.PadRight(10, '-');   // First is width, second is character sought

        }
        private static bool ReadBoolean(string message)
        {
            do
            {
                Console.WriteLine(message);
                string result = Console.ReadLine().ToUpper();  // Won't need case checking

                // Validate it is a boolean
                // TODO: Fix this expression
                // TODO shows up in the task list as it searches all files
                if (result == "Y")
                    return true;
                //if (result == "y")
                //    return true;
                if (result == "N")
                    return false;
                //if (result == "n")
                //    return false;
                // if (result == "Y" || result == "y")

                //switch (result)
                //{
                //    case "Y": return true; // Use break in statements to prevent fall thru
                //    case "y": return true;

                //    case "N": return false;
                //    case "n": return false;

                //    default: Console.WriteLine("Enter Y or N"); break;  // Break statement needs on default to allow compile
                //};

                Console.WriteLine("Enter Y or N");

            } while (true);

            // TODO: Add validation
            return false;

        }

        private static decimal ReadDecimal(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string value = Console.ReadLine();

                // Decimal types have a parse funcion
                // Searches the string and brings forth the value
                // Int32.Parse  :   Double.Parse   :   Boolean.Parse
                //decimal result;
                // if (Decimal.TryParse(value, out result))
                if (Decimal.TryParse(value, out decimal result))  // (value, out var result) is also valid
                    return result;

                Console.WriteLine("Enter a valid decimal value");

            };
        }

        private static string name;
        private static string publisher;
        private static decimal price;
        private static bool owned;
        private static bool completed;

    }

}
