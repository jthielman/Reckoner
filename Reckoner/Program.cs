using System;

namespace Reckoner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me some numbers to multiply, separated by commas.  Please.");
            var input = Console.ReadLine();
            var numberStrings = input.Split(",");
            var product = 1;
            foreach(var num in numberStrings)
            {
                product = int.Parse(num) * product;
            }
            Console.WriteLine(product);
            Console.ReadLine();
        }
    }
}
