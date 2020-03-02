using System;
using System.Text;

namespace Reckoner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Reckoner. Would you like to multiply or square numbers? (multiply/square)");
            var operation = Console.ReadLine();
            if (operation == "multiply" || operation == "square")
            {
                Console.WriteLine("Alright, enter the numbers separated by commas.");
            }
            else
            {
                Console.WriteLine("invalid operation");
            }
            var input = Console.ReadLine();
            var numberStrings = input.Split(",");
            var product = 1;
            if (operation == "multiply")
            {
                foreach(var num in numberStrings)
                {
                    product = int.Parse(num) * product;
                }
                Console.WriteLine(product);
            }
            else if (operation == "square")
            {
                var squares = new StringBuilder();
                var count = 0;
                foreach (var num in numberStrings)
                {
                    var numSquared = int.Parse(num) * int.Parse(num);
                    squares.Append(numSquared);
                    count++;
                    if (count < numberStrings.Length)
                    {
                        squares.Append(',');
                    }
                }
                Console.WriteLine(squares);
            }
            
            Console.ReadLine();
        }
    }
}
