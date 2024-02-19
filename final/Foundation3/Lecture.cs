public class Lecture:Event{

    private string _speaker;
    private int _capacity;

    public void setSpeaker(string speaker){
        _speaker = speaker;
    }

    public void setCapacity(int capacity){
        _capacity = capacity;
    }
    public string shorDesc(){
        return $"Event Type: {_eventType}\nEvent Title: {_eventTitle}\nEvent Date: {_eventDate}";
    }
    public void fullDetails(){
        string fulldetails = $"Title: {_eventTitle}\nDescription: {_eventDesc}\nDate: {_eventDate}\nAddress: {_eventAddress}\nSpeaker: {_speaker}\nCapacity {_capacity}";
        Console.WriteLine(fulldetails);
    }
}