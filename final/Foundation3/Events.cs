public class Event{
    protected string _eventType;
    protected string _eventTitle;
    protected string _eventDesc;
    protected string _eventDate;
    protected string _eventAddress;

    public void setEvent(string type){
        _eventType = type;
    }
    
    public void setTitle(string title){
        _eventTitle = title;
    }

    public void setDesc(string desc){
        _eventDesc = desc;
    }
    public void setDate(string date){
        _eventDate = date;
    }
    //The address returned from the address class will be stored as the address string
    public void setAddress(string add){
        _eventAddress = add;
    }
    public string standardDetails(){
        string details = $"Event: {_eventTitle}\n{_eventDesc}\n{_eventDate}\n{_eventAddress}";
        return details;
    }
}