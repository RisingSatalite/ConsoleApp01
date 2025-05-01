// See https://aka.ms/new-console-template for more information
using System;

namespace LuckyNumber
{
    class LuckyNumber
    {
        static void Number(string[] args)
        {
            Random rnd = new Random();
            int number = (int)Math.Floor(Math.Sqrt(rnd.Next(1, 10000)));
            Console.WriteLine("Your lucky number is");
            Console.WriteLine(number);
            Console.ReadKey();

        }
    }
}