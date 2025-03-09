using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Full Sail!");
            Console.WriteLine("Can I be so inclined, as to ask for your name?");
           string name = Console.ReadLine();
            Console.WriteLine("Wow! That's a strange name. How old are you?");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", How are you?");
            Console.WriteLine($"So...{age}, huh? That's pretty good! Congratulations!");
            Console.ReadKey();
        }
    }
}
