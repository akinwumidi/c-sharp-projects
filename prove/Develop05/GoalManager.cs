using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        int choice;
        do
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine($"Your current score: {_score}");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        CreateGoal();
                        break;
                    case 2:
                        ListGoalDetails();
                        break;
                    case 3:
                        SaveGoals();
                        break;
                    case 4:
                        LoadGoals();
                        break;
                    case 5:
                        RecordEvent();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number.");
            }

            Console.WriteLine($"Your current score: {_score}");
        } while (choice != 6);
    }

    public void CreateGoal()
    {
        Console.Write("Enter the type of goal (1. Simple, 2. Eternal, 3. Checklist): ");
        int type;
        while (!int.TryParse(Console.ReadLine(), out type) || (type < 1 || type > 3))
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
            Console.WriteLine("Enter the type of goal (1. Simple, 2. Eternal, 3. Checklist): ");
        }

        Console.Write("Enter the short name of the goal: ");
        string shortName = Console.ReadLine();
        Console.Write("Enter the description of the goal: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points of the goal: ");
        int points;
        while (!int.TryParse(Console.ReadLine(), out points) || points < 0)
        {
            Console.WriteLine("Invalid points. Please enter a non-negative integer.");
            Console.Write("Enter the points of the goal: ");
        }

        switch (type)
        {
            case 1:
                _goals.Add(new SimpleGoal(shortName, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(shortName, description, points));
                break;
            case 3:
                Console.Write("Enter the required count of the checklist goal: ");
                int requiredCount;
                while (!int.TryParse(Console.ReadLine(), out requiredCount) || requiredCount < 1)
                {
                    Console.WriteLine("Invalid required count. Please enter a positive integer.");
                    Console.Write("Enter the required count of the checklist goal: ");
                }
                _goals.Add(new ChecklistGoal(shortName, description, points, requiredCount));
                break;
        }
    }

public void ListGoalDetails()
{
    if (_goals.Count == 0)
    {
        Console.WriteLine("You have no goals recorded. Please create a new goal.");
        return;
    }

    foreach (var goal in _goals)
    {
        Console.WriteLine(goal.GetStringRepresentation());
    }
}

public void RecordEvent()
{
    if (_goals.Count == 0)
    {
        Console.WriteLine("You have no events to record. Please create a new goal to record an event.");
        return;
    }

    Console.WriteLine("Available goals:");
    for (int i = 0; i < _goals.Count; i++)
    {
        Console.WriteLine($"[{i}] { _goals[i].GetStringRepresentation()}");
    }

    Console.Write("Enter the index of the goal to record event: ");
    int index;
    while (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index >= _goals.Count)
    {
        Console.WriteLine("Invalid index. Please enter a valid index.");
        Console.WriteLine("Enter the index of the goal to record event: ");
    }

    _goals[index].RecordEvent();
    _score += _goals[index]._points;
    Console.WriteLine("Event recorded successfully.");

    if (_goals[index].IsComplete())
    {
        Console.WriteLine("Goal completed! Removing from the list.");
        _goals.RemoveAt(index);
    }

    Console.WriteLine($"Your current score: {_score}");
}


    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal._shortName},{goal._description},{goal._points}");
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        _goals.Clear();
        using (StreamReader reader = new StreamReader("goals.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string type = parts[0];
                string shortName = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                switch (type)
                {
                    case nameof(SimpleGoal):
                        _goals.Add(new SimpleGoal(shortName, description, points));
                        break;
                    case nameof(EternalGoal):
                        _goals.Add(new EternalGoal(shortName, description, points));
                        break;
                    case nameof(ChecklistGoal):
                        int requiredCount = int.Parse(parts[4]);
                        _goals.Add(new ChecklistGoal(shortName, description, points, requiredCount));
                        break;
                }
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }
}
