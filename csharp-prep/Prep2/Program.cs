using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("what is your grade percentage? ");
        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);

        string letter = "";

        if (percentage >= 90){
            letter = "A";
        }
        else if (percentage >= 80){
            letter = "B";
        }
        else if (percentage >= 70){
            letter = "C";
        }
        else if (percentage >= 60){
            letter = "D";
        }
        else{
            letter = "F";
        }
        Console.WriteLine($"your grade is {letter}");
        if (percentage >= 70){
            Console.WriteLine("You Passed");
        }
        else{
            Console.WriteLine("Please try again next time!");
        }
    }
}