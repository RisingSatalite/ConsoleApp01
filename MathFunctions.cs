using System;

namespace MathSimple
{
    public class MathFunctions
    {
        public static void Multiply()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter a number to multiply:");
            float number = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a 2nd number to multiply:");
            float number2 = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your number is");
            Console.WriteLine(number * number2);
        }

        public static void Divid()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter a number to divid:");
            float number = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number to divid by:");
            float number2 = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your number is");
            Console.WriteLine(number / number2);
        }

        public static void Add()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter a number to add:");
            float number = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a 2nd number to add:");
            float number2 = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your number is");
            Console.WriteLine(number + number2);
        }

        public static void Subtract()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter a number to subtract:");
            float number = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a 2nd number to subtract by:");
            float number2 = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your number is");
            Console.WriteLine(number - number2);
        }

        public static void Square()
        {
            Console.WriteLine("Enter a number to square:");
            float number = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your number is");
            Console.WriteLine(number * number);
        }
        public static void SquareRoot()
        {
            Console.WriteLine("Enter a number to square root:");
            float number = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your number is");
            Console.WriteLine(Math.Sqrt(number));
        }
    }
}