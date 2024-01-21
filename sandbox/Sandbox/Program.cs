// C# Basics Practice
// class Program
// {
//     static void Main(string[] args){
    
//     string myName ="Israel Akinwumi";
//     const int age = 26;

//     Console.WriteLine("##################################");
//     Console.WriteLine("  PLAYING AROUND IN THE SANDBOX");
//     Console.WriteLine("##################################"); 
//     Console.WriteLine($"My name is {myName} and i am {age} years old");
//     }
// }

 
// Abstraction practice
public class Person
{
    public string Name { get; set; }
    public DateTime Birthdate { get; set; }

    // Method to calculate age
    public int CalculateAge()
    {
        return DateTime.Now.Year - Birthdate.Year;
    }

    // Method to display birthday information
    public void DisplayBirthdayInfo()
    {
        Console.WriteLine($"{Name}'s Birthday: {Birthdate:MMMM dd}");
    }
}

// Class to represent a son
public class Son : Person
{
}
public class Family
{
    public Son[] Sons { get; set; }

    // Constructor to initialize sons
    public Family()
    {
        Sons = new Son[3];
        Sons[0] = new Son { Name = "Godwin Akinwumi", Birthdate = new DateTime(1996, 5, 31) };
        Sons[1] = new Son { Name = "Israel Akinwumi", Birthdate = new DateTime(1998, 4, 26) };
        Sons[2] = new Son { Name = "Samuel Akinwumi", Birthdate = new DateTime(2007, 7, 17) };
    }
}



class Program
{
    static void Main()
    {
        // Creating a family
        Family _myFamily = new Family();

        // Displaying age and birthday information for each son
        foreach (var son in _myFamily.Sons)
        {
            Console.WriteLine($"{son.Name}'s Age: {son.CalculateAge()} years");
            son.DisplayBirthdayInfo();
            Console.WriteLine();
        }
    }
}
