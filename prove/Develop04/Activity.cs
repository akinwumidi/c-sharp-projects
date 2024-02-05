using System;
class Activity{
    protected string _activityDisplayName;
    private string _activityName;
    private string _activityDesc;
    protected string _activityDur;

    public Activity(){
        //default constructor parameters.
		_activityDisplayName = "Unknown";
		_activityName = "Unknown";
		_activityDesc = "Unknown";
        _activityDur = "";
	}
    
    // setting the member variables
    public string setActivity(string name,string desc,string displayName){
        _activityName = name;
        _activityDesc = desc;
        _activityDisplayName = displayName;
        return $"{name}\n {desc}";
    }

    // setting the duration of time the program should run for.
    public string setDuration(string dur){
        _activityDur = dur;
        return dur;
        
    }


    // the welcoming messages to display
    public void displayMessage(){
        Console.WriteLine($"{_activityName}\n{_activityDesc}");
    }
    public void displaySpinner(){
        Console.Write("\nGet Ready...");
        int i = 4;
        while(i<=5){
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("|"); // Erase the + character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            i-=1;
            if(i ==-1){
                return;
            }
        }
        Console.WriteLine();
    }
    public void displaySpinner2(){
        Console.Write("Reflect...");
        int i = 4;
        while(i<=5){
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(250);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("|"); // Erase the + character
            Thread.Sleep(250);
            Console.Write("\b \b"); // Erase the + character
            i-=1;
            if(i ==-1){
                return;
            }
        }
        Console.WriteLine();
    }
    public void displaySpinner3(){
        Console.Write("You may begin in...");
        int i = 4;
        while(i<=4){
            Thread.Sleep(1000);
            Console.Write("\r");  // Move back to the beginning of the line
            Console.Write($"You may begin in... {i} sec"); 
            i-=1;
            if(i ==-1){
                Console.Write("\r");  // Move back to the beginning of the line
                Console.Write("                         ");
                Console.Write("\r");  // Move back to the beginning of the line
                Console.Write($"You may begin:\n"); 
                return;
            }
        }
        Console.WriteLine();
    }
    // the finishing message to display
    public void finishingMsg(){
        Console.WriteLine("   ");
        Console.WriteLine("well done!!");
		Console.WriteLine( $"You have completed another {_activityDur}sec of {_activityDisplayName} today");
	}

}