using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public string _Prompt { get; }
    public string _Response { get; }
    public string _Date { get; }

    public Entry(string prompt, string response, string date)
    {
        _Prompt = prompt;
        _Response = response;
        _Date = date;
    }

    public override string ToString()
    {
        return $"Date: {_Date}\nPrompt: {_Prompt}\nResponse: {_Response}\n";
    }
}

class Journal
{
    public List<Entry> _entries;
    public List<string> _prompts;
    public Journal()
    {
        _entries = new List<Entry>();
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }
    public void PrintMenu()
    {
        Console.WriteLine("\n|| +++++++++++++++ Welcome to Journal Program ++++++++++++++++ ||\n ");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display current / loaded journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");
        Console.WriteLine("\n|| +++++++++++++++ Welcome to Journal Program ++++++++++++++++ || \n");
        Console.Write("Please Enter a response ( 1-5 ): ");
    }
 

    public void AddEntry()
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        Entry entry = new Entry(prompt, response, date);
        _entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._Date}|{entry._Prompt}|{entry._Response}");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        _entries.Clear();
        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                string[] parts = reader.ReadLine().Split('|');
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                Entry entry = new Entry(prompt, response, date);
                _entries.Add(entry);
            }
        }
    }

    public void LoadJournal()
    {
        List<string> _savedFileNames = GetSavedFileNames();
        if (_savedFileNames.Count > 0)
        {
            Console.WriteLine("Available Journals to Load:");
            for (int i = 0; i < _savedFileNames.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_savedFileNames[i]}");
            }

            Console.Write("Enter the number of the journal to load: ");
            if (int.TryParse(Console.ReadLine(), out int journalNumber) && journalNumber >= 1 && journalNumber <= _savedFileNames.Count)
            {
                string selectedFileName = _savedFileNames[journalNumber - 1];
                LoadFromFile(selectedFileName);
                Console.WriteLine($"\n{selectedFileName} Journal loaded, please enter (2) to Display content");

            }
            else
            {
                Console.WriteLine($"\nInvalid entry. Please enter a valid number between ( 1-{_savedFileNames.Count} ).");

            }
        }
        else
        {
            Console.WriteLine("\nNo saved journals available to load, Please write and save a journal");

        }
    }

    public static List<string> GetSavedFileNames()
    {
        List<string> _savedFileNames = new List<string>();

        DirectoryInfo directory = new DirectoryInfo(Directory.GetCurrentDirectory());
        foreach (var file in directory.GetFiles("*.txt"))
        {
            _savedFileNames.Add(file.Name);
        }

        return _savedFileNames;
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}

class Program
{ 
    static void Main()
    {
        Journal _journal = new Journal();
        bool exit = false;

        do
        {
            _journal.PrintMenu();
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        _journal.AddEntry();
                        break;
                    case 2:
                        _journal.DisplayJournal();
                        break;
                    case 3:
                        Console.Write("Please enter a name to save journal, end with (.txt): ");
                        string userFileName = Console.ReadLine();
                        _journal.SaveToFile(userFileName);
                        break;
                    case 4:
                        _journal.LoadJournal();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please enter a number.");
            }

        } while (!exit);
    }

}
