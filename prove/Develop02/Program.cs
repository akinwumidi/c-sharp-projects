using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public string Prompt { get; }
    public string Response { get; }
    public string Date { get; }

    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }
}

class Journal
{
    private List<Entry> entries;
    private List<string> prompts;

    public Journal()
    {
        entries = new List<Entry>();
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    public void AddEntry()
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        Entry entry = new Entry(prompt, response, date);
        entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"\n{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        entries.Clear();
        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                string[] parts = reader.ReadLine().Split('|');
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                Entry entry = new Entry(prompt, response, date);
                entries.Add(entry);
            }
        }
    }

    public static List<string> GetSavedFileNames()
    {
        List<string> savedFileNames = new List<string>();

        DirectoryInfo directory = new DirectoryInfo(Directory.GetCurrentDirectory());
        foreach (var file in directory.GetFiles("*.txt"))
        {
            savedFileNames.Add(file.Name);
        }

        return savedFileNames;
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        bool exit = false;

        do
        {
            PrintMenu();
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        journal.AddEntry();
                        break;
                    case 2:
                        journal.DisplayJournal();
                        break;
                    case 3:
                        Console.Write("Please enter a name to save journal, end with (.txt): ");
                        string saveFileName = Console.ReadLine();
                        journal.SaveToFile(saveFileName);
                        break;
                    case 4:
                        LoadJournal(journal);
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid entry. Please enter a number.");
            }

        } while (!exit);
    }

    static void PrintMenu()
    {
        Console.WriteLine("\n|| +++++++++++++++ Welcome to Journal Program ++++++++++++++++ ||\n ");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");
        Console.WriteLine("\n|| +++++++++++++++ Welcome to Journal Program ++++++++++++++++ || \n");
        Console.Write("Please Enter a response ( 1-5 ): ");
    }

    static void LoadJournal(Journal journal)
    {
        List<string> savedFileNames = Journal.GetSavedFileNames();
        if (savedFileNames.Count > 0)
        {
            Console.WriteLine("Available Journals to Load:");
            for (int i = 0; i < savedFileNames.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {savedFileNames[i]}");
            }

            Console.Write("Please enter the journal number you wish to load: ");
            if (int.TryParse(Console.ReadLine(), out int journalNumber) && journalNumber >= 1 && journalNumber <= savedFileNames.Count)
            {
                string selectedFileName = savedFileNames[journalNumber - 1];
                journal.LoadFromFile(selectedFileName);
                Console.WriteLine($"Journal loaded from {selectedFileName}");
            }
            else
            {
                Console.WriteLine("Invalid entry. Please enter a valid number.");
            }
        }
        else
        {
            Console.WriteLine("No saved journals available to load, Please write and save a journal");
        }
    }
}
