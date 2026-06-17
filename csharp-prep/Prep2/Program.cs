using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        int remainder = grade % 10;
        string sign;

// determining letter grade
        string letterGrade;
        if (grade >= 70 && grade < 80)
        {
            letterGrade = "C";
        }
        else if (grade >= 80 && grade < 90)
        {
            letterGrade = "B";
        }
        else if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 60 && grade < 70)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
// determining sign of letter grade 
        if (letterGrade != "F" && remainder < 3)
        {
            sign = "-";
        }
        else if (remainder >= 7 && (letterGrade != "F" && letterGrade != "A"))
        {
            sign = "+";
        }
        else
        {
            sign = "";
        }
// determining "a" or "an"
        if (letterGrade == "A" || letterGrade == "F")
        {
            Console.WriteLine($"You received an {letterGrade}{sign}."); 
        }
        else
        {
            Console.WriteLine($"You received a {letterGrade}{sign}");
        }
// pass or fail message
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you failed the class. Try again next year.");
        }

    }
}