using System;
class Reflection:Activity{
    private List<string> _reflectQues = new List<string>();
    private List<string> _reflectLists = new List<string>();

    public void addQues(string rQues){
        _reflectQues.Add(rQues);
    }

    public void addListsPrompt(string ques){
        _reflectLists.Add(ques);
    }
    public string displaRefQues(){
        // randomly display the questions inside the list
        var random = new Random();
        //saving the random number picked from the length of the list into the string variable index.
        int index = random.Next(_reflectQues.Count);
        string wrds = _reflectQues[index];
        Console.WriteLine(wrds); //question
        // Console.WriteLine();
        // Console.WriteLine();
        return $"{wrds}";
    }
    public void displayQuesList(int t){
        foreach(var quest in _reflectLists){
                Console.WriteLine();
                Console.WriteLine(quest);
                displaySpinner2();
                Console.WriteLine();
        }
    }
    public void reflect()
{
    displayMessage();

    Console.Write("\nHow long in seconds would you like for your session?: ");
    string Dur = Console.ReadLine();
    displaySpinner();
    Console.WriteLine("\nConsider the following Prompt:");
    string refectionQuestion = displaRefQues();
    Console.Write("\nWhen you have something in mind, ( press Enter ) to continue or q to quit: ");
    string Proceed = Console.ReadLine();

    while (Proceed.ToLower() != "q")
    {
        string timeToRun = setDuration(Dur);
        int start = 0;
        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience: \n");
        displaySpinner3();
        //pass the value from the Dur into the setduration function which returns a string which will be saved as the time to run the program.
        while (start < int.Parse(timeToRun) / 7)
        {
            displayQuesList(int.Parse(timeToRun));
            start += 1;
        }
        finishingMsg();
        return; 
    }
}

}