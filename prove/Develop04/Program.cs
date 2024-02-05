using System;

class Program
{
    static void Main(string[] args)
    {


        Reflection reflect = new Reflection();
        string rName = "\n+++++++++++++ Reflecting Activity +++++++++++++\n";
        string rdisplayName = " Reflecting Activity ";
        string rDesc = "This activity will help you to calm down and master the art of reflecting\n";
        reflect.setActivity(rName,rDesc,rdisplayName);
        //Questions 
        string rq1,rq2,rq3,rq5;
        rq1 = ("Ques: Think of a time when you stood up for someone else");
        rq2 = ("Ques: Think of a time when you did something really difficult.");
        rq3 = ("Ques: Think of a time when you helped someone in need.");
        rq5 = ("Ques: Think of a time when you did something truly selfless.");
        reflect.addQues(rq1);
        reflect.addQues(rq2);
        reflect.addQues(rq3);
        reflect.addQues(rq5);


        //sub Questions lists
        string rl1,rl2,rl3,rl4,rl5,rl6,rl7,rl8,rl9;
        rl1 = "Why was this experience meaningful to you?";
        rl2 = "Have you ever done anything like this before?";
        rl3 = "How did you get started?";
        rl4 = "How did you feel when it was complete?";
        rl5 = "What made this time different than other times when you were not as successful?";
        rl6 = "What is your favorite thing about this experience?";
        rl7 = "What is your favorite thing about this experience?";
        rl8 = "What did you learn about yourself through this experience?";
        rl9 = "How can you keep this experience in mind in the future?";
        reflect.addListsPrompt(rl1);
        reflect.addListsPrompt(rl2);
        reflect.addListsPrompt(rl3);
        reflect.addListsPrompt(rl4);
        reflect.addListsPrompt(rl5);
        reflect.addListsPrompt(rl6);
        reflect.addListsPrompt(rl7);
        reflect.addListsPrompt(rl8);
        reflect.addListsPrompt(rl9);





        string BrName = "\n+++++++++++++ Breathing Activity +++++++++++++\n";
        string displayName = " Breathing Activity ";
        string BrDesc = "This activity will help you relax by walking your through breathing in and out slowly.\nClear your mind and focus on your breathing.";
        Breathing breathe = new Breathing();
        breathe.setActivity(BrName,BrDesc,displayName);
        

        string lName = "\n+++++++++++++ Listing Activity +++++++++++++\n";
        string ldisplayName = " Listing Activity ";
        string lDesc = "This activity will help you reflect on the good things in your life\nby having you list as many things as you can in a certain area.";
        Listing listen = new Listing();
        listen.setActivity(lName,lDesc,ldisplayName);


        string lq1 = "Ques: Who are people that you appreciate?";
        string lq2 = "Ques: What are personal strengths of yours?";
        string lq3 = "Ques: Who are people that you have helped this week?";
        string lq4 = "Ques: When have you felt the Holy Ghost this month?";
        string lq5 = "Ques: Who are some of your personal heroes?";
        listen.setQuestion(lq1);
        listen.setQuestion(lq2);
        listen.setQuestion(lq3);
        listen.setQuestion(lq4);
        listen.setQuestion(lq5);





    string PrintMenu(){ 
        Console.WriteLine("\n|| +++++++++++++++ Mindfulness Program ++++++++++++++++ ||\n ");
        Console.WriteLine("Menu Options:\n");
        Console.WriteLine("    1. Start Breathing activity");
        Console.WriteLine("    2. Start Reflecting activity");
        Console.WriteLine("    3. Start listing activity");
        Console.WriteLine("    4. Quit"); 
        Console.WriteLine("\n|| +++++++++++++++ Mindfulness Program ++++++++++++++++ || \n");
        Console.Write("Please Enter a response ( 1-4 ): ");
        string userChoice = Console.ReadLine();
            return userChoice;
    }



    bool replay = true;

while (replay)
{
    string userChoice = PrintMenu();

    if (int.TryParse(userChoice, out int choice))
    {
        switch (choice)
        {
            case 1:
                breathe.breathing();
                break;
            case 2:
                reflect.reflect();
                break;
            case 3:
                listen.listen();
                break;
            case 4:
                replay = false;
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number.");
    }

}
        
    }
}