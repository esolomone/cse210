using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {   
        int number = -1;
        List<int> numbers = new List<int>();
        do
        {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        Console.Write("Enter number: ");
        number = int.Parse(Console.ReadLine());
        numbers.Add(number);
        } while (number != 0);
        int sum = 0;
        foreach (int num in numbers) 
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}.");

    }
}