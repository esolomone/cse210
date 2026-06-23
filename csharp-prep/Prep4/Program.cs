using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {   
        int number = -1;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        do
        {
        Console.Write("Enter number: ");
        number = int.Parse(Console.ReadLine());
        numbers.Add(number);
        } while (number != 0);
        int sum = 0;
        int largestNumber = -10000;
        foreach (int num in numbers) 
        {
            sum += num;
            if (num > largestNumber)
            {
                largestNumber = num;
            }
        }
  
        float average = sum / (numbers.Count - 1);
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {largestNumber}");
    }
}