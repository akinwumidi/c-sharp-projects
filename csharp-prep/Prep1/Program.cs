using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("What is your First Name? ");
        string fname = Console.ReadLine();
        Console.Write("What is your Last Name? ");
        string Lname = Console.ReadLine();

        Console.WriteLine($"Your name is {Lname}, {fname} {Lname}.");
    }
}