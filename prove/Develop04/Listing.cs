using System;
class Listing:Activity{

    public List<string> _listingQues = new List<string>();
    private List<string> _listingAns = new List<string>();
    


    //setting the questions to be displayed to the user
    public void setQuestion(string question){
        _listingQues.Add($"{question}");
    }

    public string random(){
            var random = new Random();
            //saving the random number picked from the length of the list into the string variable index.
            int index = random.Next(_listingQues.Count);
            string wrds = _listingQues[index];
            Console.WriteLine(wrds);
            return $"{wrds}";
        }


    //take the returned question and pass it as a parameter to this function 
    public void saveAns(string ques, string ans){
		_listingAns.Add($"{ques}\nAns: {ans}");
        }


    public void listen(){
        //welcoming message
        displayMessage();
        Console.Write("\nHow long in seconds would you like for your session?: ");
        string Dur = Console.ReadLine();
        displaySpinner(); 
        Console.Write("\n");
        Console.WriteLine("\nList as many response you can to the following prompt: ");
        string q = random();
        displaySpinner3();
        
        //pass the value from the Dur into the setduration function which returns a string wich will be saved as the time to run the program. 
        string timeToRun = setDuration(Dur);
        int start = 0;
        while (start < int.Parse(timeToRun)/4)
        {
            Console.Write("> ");
            string ans = Console.ReadLine();
            //Saving the answers and specific question to a list for viewing later;
            saveAns(q,ans); 
            start += 1;
        } 

        Console.WriteLine($"You have entered {_listingAns.Count} responses\n");
        Console.Write("Will you like to view your responses? (yes or no): ");
        string userChoice = Console.ReadLine();
        if(userChoice.ToLower() == "yes"){
            displayEntries();
            Console.WriteLine($"Your {timeToRun}s is completed Thanks for your responses");
            displaySpinner();
            finishingMsg();
            return;
        }else if(userChoice.ToLower() == "no"){
            Console.WriteLine($"Your {timeToRun}s is completed Thanks for your responses");
            displaySpinner();
            finishingMsg();
        }
    }
    public void displayEntries(){
        Console.WriteLine("\nYour list of responses");
            if(_listingAns.Count>0){
                foreach(string ans in _listingAns){
                    Console.WriteLine(ans);
                }
            }else{
                Console.WriteLine("YOU HAVE NO ANSWERS");
            }
    }
}