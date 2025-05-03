using System;
using System.Data;
using System.Diagnostics.Contracts;

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

        public static void Power()
        {
            Console.WriteLine("Enter a number to power:");
            float number = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the power:");
            float number2 = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your number is");
            Console.WriteLine(Math.Pow(number, number2));
        }
        public static void Factorial()
        {
            Console.WriteLine("Enter a number to factorial:");
            float number = (float)Convert.ToDouble(Console.ReadLine());

            float result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            Console.WriteLine("Your number is");
            Console.WriteLine(result);
        }
        public static void Logarithm()
        {
            Console.WriteLine("Enter a number to logarithm:");
            float number = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the base:");
            float number2 = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your number is");
            Console.WriteLine(Math.Log(number, number2));
        }
        public static void LogarithmNatural()
        {
            Console.WriteLine("Enter a number to logarithm natural:");
            float number = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your number is");
            Console.WriteLine(Math.Log(number));
        }

        public static void ExpressionSolver()
        {
            Console.WriteLine("Enter an expression to solve (e.g., 2+2):");
            string expression = Console.ReadLine() ?? string.Empty;

            // Simple expression evaluation (not secure for production use)
            var result = new DataTable().Compute(expression, null);
            Console.WriteLine("Your result is: " + result);
        }
        public static void TrigonometricFunctions()
        {
            Console.WriteLine("Enter an angle in degrees:");
            float angle = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sine: " + Math.Sin(angle * Math.PI / 180));
            Console.WriteLine("Cosine: " + Math.Cos(angle * Math.PI / 180));
            Console.WriteLine("Tangent: " + Math.Tan(angle * Math.PI / 180));
        }
    }
}