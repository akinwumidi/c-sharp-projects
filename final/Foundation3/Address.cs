public class Address{

    private string _street;
    private string _city;
    private string _state;
    private string _province;
    private string _country;
    
    public Address(string street, string city,string state,string province,string country){
        _street = street;
        _city = city;
        _state = state;
        _province = province;
        _country = country;
    }

    //Get the Event's address
    public string getFullAdd(){
       return $" Street: {_street}\nCity: {_city}\nState: {_state}\nCountry: {_country}";
    }
}