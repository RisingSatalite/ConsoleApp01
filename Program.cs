// See https://aka.ms/new-console-template for more information
using System;
using LuckyNumber;
using MathSimple;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Lucky.Number(args);
            MathFunctions.ExpressionSolver();
        }
    }
}