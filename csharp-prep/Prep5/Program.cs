using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program! ");
    }
    static string PromptUsername()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }
    static void PromptUserBirthYear(out int userBirthYear)
    {
        Console.Write("What year were you born? ");
        userBirthYear = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int x)
    {
        int squaredx = x * x;
        return squaredx;
    }
    static void DisplayResult(string name, int number, int birthyear, int squarednumber)
    {
        int age = 2026 - birthyear;
        Console.WriteLine($"{name}, the square of your number is {squarednumber}.");
        Console.WriteLine($"{name}, you will turn {age}.");

    }
    static void Main(string[] args)
    {
        int x;
        DisplayWelcome();
        string userName = PromptUsername();
        int userNumber = PromptUserNumber();
        PromptUserBirthYear(out int userBirthYear);
        int squaredUserNumber = SquareNumber(userNumber);
        DisplayResult(userName, userNumber, userBirthYear, squaredUserNumber);

      

    }
}