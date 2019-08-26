using System;

namespace Calculators
{

    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("\t\t\t Concole Calculator\r");
            Console.WriteLine("\t\t\t-------------------------------\r");


            Console.WriteLine("\t\t\tInput first number\n");
            double firstnumber = Double.Parse(Console.ReadLine());

            Console.WriteLine("\t\t\t Enter econd number");
            double secondnumber = Double.Parse(Console.ReadLine());

            Console.WriteLine("\t\t\tChose an : (+, -, *, /, %, ^)\n");
            char myopp = char.Parse(Console.ReadLine());

            EmptyClass User = new EmptyClass(firstnumber, secondnumber, myopp);

        }
    }
}