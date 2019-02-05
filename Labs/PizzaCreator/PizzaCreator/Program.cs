/*
 * Richard Islas
 * Pizza Creator ITSE 1430
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static bool Menu()
        {
            Console.WriteLine("\n(N)ew Order" + "\n(D)isplay Order" + "\n(M)odify Order" + "\nE(x)it");
            Console.WriteLine("\nPlease choose a menu option from above: ");
            string result = Console.ReadLine().ToUpper();

            if (result == "N")
                NewOrder();

            //switch (result)
            //{
            //    case "N": return true;
            //    case "D": return true;
            //    case "M": return true;
            //    case "X": return true;

            //    default: return false; break;    
            //};

            return false;
        }

        private static void NewOrder()
        {
            Console.WriteLine("\n(S)mall  $5" + "\n(M)edium  $6.25" + "\n(L)arge  $8.25" + "\n\nChoose size: ");
            size = Console.ReadLine().ToUpper();

            if (size == "S")
                price = price + 5.0m;
            if (size == "M")
                price = price + 6.25m;
            if (size == "L")
                price = price + 8.25m;

            Console.WriteLine(size);
            Console.WriteLine(price);
        }

        private static string size;
        private static string sauce;
        private static decimal price;
    }
}
