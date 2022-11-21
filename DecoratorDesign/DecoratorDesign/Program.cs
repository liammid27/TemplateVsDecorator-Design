using System;

namespace DecoratorDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCharacter baseCharacter = new BaseCharacter();

            Console.WriteLine("CHOOSE YOUR CLASS \n");

            Hunter hunterDecorator = new Hunter(baseCharacter);
            string hunterString = hunterDecorator.CreateCharacter();
            Console.WriteLine("\n " + hunterString);

            Brute bruteDecorator = new Brute(baseCharacter);
            string bruteString = bruteDecorator.CreateCharacter();
            Console.WriteLine("\n " + bruteString);

            Mage mageDecorator = new Mage(baseCharacter);
            string mageString = mageDecorator.CreateCharacter();
            Console.WriteLine("\n " + mageString);

            Console.Read();

        }
    }
}
