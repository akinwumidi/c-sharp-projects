public class Reception:Event{

    private string _rsvpEmail;
    private string _register;

    //Ask if the user wants to rsvp, if true then the user will have to provide name and phone number.
    public void setRsvpEmail(string rsvpemail){

        _rsvpEmail = rsvpemail;
    }
    public string getRsvpEmail(){
        return _rsvpEmail;
    }
    public string shorDesc(){
        return $"Event Type: {_eventType}\nEvent Title: {_eventTitle}\nEvent Date: {_eventDate}";
    }
    
    public void fullDetails(){
        string fulldetails = $"Title: {_eventTitle}\nDescription: {_eventDesc}\nDate: {_eventDate}\nAddress: {_eventAddress}";
        Console.WriteLine(fulldetails);
        Console.Write("Do you want a reservation? (Yes or No): ");
        string ans = Console.ReadLine();
        if(ans == "Yes" || ans == "yes"){
            Console.Write("Enter your email Address: ");
            string email = Console.ReadLine();
            setRsvpEmail(email);
            
            Console.WriteLine($"{fulldetails}\n\nThank you for your respone!\nWe will get back to you on this Email: {getRsvpEmail()}");
        }
        
    }
}



/*Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
Short description - Lists the type of event, title, and the date.*/