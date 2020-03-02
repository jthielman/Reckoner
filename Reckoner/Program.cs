using System;
using System.Text;

namespace Reckoner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Reckoner. Enter an operation (+ - * / ^2 avg) and some numbers separated by commas.");
            var input = Console.ReadLine();
            var operation = input.Split(" ")[0];
            if (operation == "+" || operation == "-" || operation == "*" || operation == "/" || operation == "^2" || operation == "avg")
            {
                var operands = input.Split(" ")[1];
                var numberStrings = operands.Split(",");
                var sum = 0;
                var product = 1;
                if (operation == "+")
                {
                    foreach (var num in numberStrings)
                    {
                        sum += int.Parse(num);
                    }
                    Console.WriteLine(sum);
                }
                else if (operation == "-")
                {
                    var minuend = int.Parse(numberStrings[0]);
                    var subtrahends = new string[numberStrings.Length - 1];
                    Array.ConstrainedCopy(numberStrings, 1, subtrahends, 0, numberStrings.Length - 1);
                    foreach (var subtrahend in subtrahends)
                    {
                        minuend -= int.Parse(subtrahend);
                    }
                    Console.WriteLine(minuend);
                }
                else if(operation == "*")
                {
                    foreach(var num in numberStrings)
                    {
                        product *= int.Parse(num);
                    }
                    Console.WriteLine(product);
                }
                else if (operation == "/")
                {
                    var dividend = int.Parse(numberStrings[0]);
                    var divisors = new string[numberStrings.Length - 1];
                    Array.ConstrainedCopy(numberStrings, 1, divisors, 0, numberStrings.Length - 1);
                    foreach(var divisor in divisors)
                    {
                        dividend /= int.Parse(divisor);
                    }
                    Console.WriteLine(dividend);
                }
                else if (operation == "^2")
                {
                    var squares = new StringBuilder();
                    var count = 0;
                    foreach (var num in numberStrings)
                    {
                        var numSquared = int.Parse(num) * int.Parse(num);
                        squares.Append(numSquared);
                        if (++count < numberStrings.Length)
                        {
                            squares.Append(',');
                        }
                    }
                    Console.WriteLine(squares);
                }
                else if (operation == "avg")
                {
                    foreach (var num in numberStrings)
                    {
                        sum += int.Parse(num);
                    }
                    var mean = sum / numberStrings.Length;
                    Console.WriteLine(mean);
                }
            }
            else
            {
                Console.WriteLine("invalid input");
            }
            Console.ReadLine();
        
        
        }
    }
}
