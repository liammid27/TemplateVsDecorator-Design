using System;

namespace TemplateDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prepare Nescafe Coffee\n");
            CoffeeTemplate coffee = new NescafeCoffee();
            coffee.MakeCoffee();

            Console.WriteLine();

            Console.WriteLine("Prepare Bru Coffee\n");
            CoffeeTemplate coffee2 = new BruCoffee();
            coffee2.MakeCoffee();

            Console.ReadLine();

        }
    }
}
