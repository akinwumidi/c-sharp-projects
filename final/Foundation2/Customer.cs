public class Customer{

    private string _name;
    private string _address;

    //Setting the name
    public void setname(string name){
        _name = name;
    }

    //Getting the name
    public string getName(){
        return $"Customer name: {_name}";
    }
    //Add address
    public void setAddress(string add){
        _address = add;
    }
    public string getAddress(){

        return  _address;
    }


}