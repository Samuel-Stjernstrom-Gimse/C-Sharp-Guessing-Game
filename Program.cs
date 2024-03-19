using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            var randomNumber = random.Next(0, 101);
            int guess;
            var counter = 0;
            
            Console.WriteLine("guess a number between 0-100");
            
            do
            {
                guess = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                counter++;
                if (guess == randomNumber)
                {
                    Console.WriteLine($"Correct!! the Number is  {randomNumber} :) you used {counter} tries");
                }
                else
                {
                    Console.WriteLine(guess < randomNumber ? "number bigger that that" : "number is smaller than that");
                }
            } while (guess != randomNumber);
            
            Console.ReadLine();
        }
    }
}