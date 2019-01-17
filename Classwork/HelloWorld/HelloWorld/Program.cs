using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        //Single line comment
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Hello ");
            Console.WriteLine(name);

            //String examples
            //string message = "Hello " + name;
            //Console.WriteLine(message);
            //message += name;
        }
    }
}
