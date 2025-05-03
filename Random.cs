// See https://aka.ms/new-console-template for more information
using System;

namespace LuckyNumber
{
    class Lucky
    {
        public static void Number(string[] args)
        {
            Random rnd = new Random();
            int number = (int)Math.Floor(Math.Sqrt(rnd.Next(1, 10000)));
            Console.WriteLine("Your lucky number is");
            Console.WriteLine(number);
            Console.ReadKey();

        }

        public static void NUmberGuess()
        {
            Random rnd = new Random();
            int number = (int)Math.Floor(Math.Sqrt(rnd.Next(1, 10000)));
            Console.WriteLine("Guess the lucky number between 1 and 10000");
            int guess = Convert.ToInt32(Console.ReadLine());
            while(true)
            {
                if (guess == number)
                {
                    Console.WriteLine("You guessed it right!");
                    break;
                }
                else if (guess < number)
                {
                    Console.WriteLine("Your guess is too low!");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                else if (guess > number)
                {
                    Console.WriteLine("Your guess is too high!");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}