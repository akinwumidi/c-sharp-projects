using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Scripture> scriptures = ReadScripturesFromFile("bible_verses.txt");

            do
            {
                Console.Clear();
                DisplayMenu();
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "quit":
                        Console.WriteLine("Quitting the program. Displaying all memorized scriptures.");
                        DisplayAllScriptures(scriptures);
                        SaveScripturesToFile("memorized_scriptures.txt", scriptures);
                        Environment.Exit(0);
                        break;
                    case "enter":
                        DisplayRandomScripture(scriptures);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 'enter' or 'quit'.");
                        break;
                }

            } while (true);
        }

        static void DisplayMenu()
        {
            Console.WriteLine("1. Enter - Display a random scripture with hidden words");
            Console.WriteLine("2. Quit - Quit the program and display all memorized scriptures");
        }

        static List<Scripture> ReadScripturesFromFile(string filePath)
        {
            List<Scripture> scriptures = new List<Scripture>();

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                for (int i = 0; i < lines.Length; i += 2)
                {
                    string referenceLine = lines[i];
                    string textLine = lines[i + 1];

                    Reference reference = ParseReference(referenceLine);
                    Scripture scripture = new Scripture(reference, textLine);
                    scriptures.Add(scripture);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: File {filePath} not found.");
            }

            return scriptures;
        }

        static Reference ParseReference(string referenceLine)
        {
            string[] parts = referenceLine.Split(' ');
            string book = parts[0];
            int chapter;
if (int.TryParse(parts[1].Split(':')[0], out chapter))
{
    // Successfully parsed the chapter as an integer
    // Continue with your logic here
}
else
{
    // Handle the case where parsing fails (non-numeric input)
    Console.WriteLine("Invalid chapter format. Unable to parse as integer.");
}

            string versePart = parts[1].Split(':')[1];

            if (versePart.Contains('-'))
            {
                int startVerse = int.Parse(versePart.Split('-')[0]);
                int endVerse = int.Parse(versePart.Split('-')[1]);
                return new Reference(book, chapter, startVerse, endVerse);
            }
            else
            {
                int verse = int.Parse(versePart);
                return new Reference(book, chapter, verse);
            }
        }

        static void DisplayRandomScripture(List<Scripture> scriptures)
        {
            Random random = new Random();
            int randomIndex = random.Next(scriptures.Count);
            Scripture randomScripture = scriptures[randomIndex];

            Console.Clear();
            Console.WriteLine("Random Scripture with Hidden Words:");
            Console.WriteLine(randomScripture.GetDisplayText());

            Console.Write("\nPress Enter to continue or type 'quit' to end: ");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
            {
                Console.WriteLine("Quitting the program. Displaying all memorized scriptures.");
                DisplayAllScriptures(scriptures);
                SaveScripturesToFile("memorized_scriptures.txt", scriptures);
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                randomScripture.HideRandomWords(3); // Change the number of hidden words as needed
                Console.WriteLine("Scripture with 3 Random Words Hidden:");
                Console.WriteLine(randomScripture.GetDisplayText());
            }
        }

        static void DisplayAllScriptures(List<Scripture> scriptures)
        {
            Console.WriteLine("All Memorized Scriptures:");
            foreach (Scripture scripture in scriptures)
            {
                Console.WriteLine(scripture.GetDisplayText() + "\n");
            }
        }

        static void SaveScripturesToFile(string filePath, List<Scripture> scriptures)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Scripture scripture in scriptures)
                    {
                        writer.WriteLine(scripture.GetDisplayText());
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine($"Error: Could not write to file {filePath}.");
            }
        }
    }
}
