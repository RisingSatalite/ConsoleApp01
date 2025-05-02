using System;

namespace MathSimple
{
    public class MathFunctions
    {
        public static void Multiply()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter a number to multiply:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a 2nd number to multiply:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number is");
            Console.WriteLine(number * number2);
        }

        public static void Divid()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter a number to divid:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number to divid by:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number is");
            Console.WriteLine(number / number2);
        }
    }
}