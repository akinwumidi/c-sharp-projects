using System;

class Program
{
    static void Main()
    {
        // Initialize the scripture
        Reference reference = new Reference("Proverbs", 5, 6);
        string originalScriptureText = "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, originalScriptureText);

        // Memorization loop
        do
        {
            Console.Clear();
            DisplayScripture(scripture);

            Console.Write("\nPress Enter to continue or type 'quit' to exit: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
                break;

            HideRandomWords(scripture, 2); // Hide 2 words in each iteration

        } while (!scripture.IsCompletelyHidden());

        // Display final results
        Console.Clear();
        Console.WriteLine("\nCongratulations! You tried memorizing a scripture.\n");
        Console.WriteLine("\n++++++++++++++++++++++++++ Final Hidden Scriptural Verse:\n");
        DisplayScripture(scripture);

        // Display untempered scripture
        Console.WriteLine("\n++++++++++++++++++++++++++ Full Untempered Scriptural Verse:\n");
        Console.WriteLine(originalScriptureText);
        Console.WriteLine("\n");
    }

    // Display the current state of the scripture
    static void DisplayScripture(Scripture scripture)
    {
        Console.WriteLine(scripture.GetDisplayText());
    }

    // Hide a specified number of random words in the scripture
    static void HideRandomWords(Scripture scripture, int numberOfWordsToHide)
    {
        scripture.HideRandomWords(numberOfWordsToHide);
    }
}
