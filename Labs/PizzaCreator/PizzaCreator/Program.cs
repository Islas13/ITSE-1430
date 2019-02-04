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
            string result = Console.ReadLine(); 

            result = Console.ReadLine().ToUpper();

            switch (result)
            {
                case "N": return true;
                case "D": return true;
                case "M": return true;
                case "X": return true;

                default: return false; break;    
            };
        }

        private static void NewOrder()
        {
            Console.WriteLine("\nChoose size: " + "\nSmall" + "\nMedium" + "\nLarge");
            size = Console.ReadLine();

            
        }

        private static string size;
        private static string sauce;
    }
}
