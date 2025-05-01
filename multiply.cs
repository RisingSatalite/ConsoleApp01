using System;

namespace MathSimple
{
    internal class MathFunctions
    {
        static void Multiply(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter a number to multiply:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a 2nd number to multiply:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your lucky number is");
            Console.WriteLine(number * number2);
        }
    }
}