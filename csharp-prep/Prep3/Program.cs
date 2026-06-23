using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guessNumber = -1;
        do
        {
            Console.WriteLine("Guess the magic number. ");
            guessNumber = int.Parse(Console.ReadLine());

            if (magicNumber == guessNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (magicNumber > guessNumber)
            {
            Console.WriteLine("higher"); 
            }
            else
            {
                Console.WriteLine("lower");
            }
        } while (magicNumber != guessNumber);
    }
}