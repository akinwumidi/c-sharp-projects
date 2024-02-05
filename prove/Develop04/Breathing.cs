using System;
class Breathing:Activity{

    public void breathIn(int t){
        int i = 1;
        Console.Write("\nBreathe in... ");
        while(i<=4){
            
            Thread.Sleep(1000);
            Console.Write("\r");  // Move back to the beginning of the line
            Console.Write($"Breathe in... {i} sec");  
            i+=1;
        } 
    } 

    public void breathOut(int t){
        int i = 4;
        Console.Write("Now breathe out... ");
        while(i<=4){
            Thread.Sleep(1000);
            Console.Write("\r");  // Move back to the beginning of the line
            Console.Write($"Breathe out... {i} sec"); 
            i-=1;
            if(i ==-1){
                return;
            }
        } 
    }
 public void breathing(){
    displayMessage();
    Console.Write("\nHow long in seconds would you like for your session?: ");
    string userChoice = Console.ReadLine();
    displaySpinner();
    Console.Write("\n");

    //pass the value from the Dur into the setduration function which returns a string wich will be saved as the time to run the program.
    string timeToRun = setDuration(userChoice);
    int start = 0;
    while(start<int.Parse(timeToRun)/7){
        breathIn(int.Parse(timeToRun));
        Console.WriteLine();
        breathOut(int.Parse(timeToRun));
        Console.WriteLine("");
        start+=1;
    }
    finishingMsg();
 }

}