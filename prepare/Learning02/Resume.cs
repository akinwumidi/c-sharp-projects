public class Resume
{
    public string _personName="";
    public List<Job> _jobs = new List<Job>();

    public Resume()
    {

    }
    public void Display(){
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs:");
        foreach(Job jobItem in _jobs){
            jobItem.Display();
        }
    }

   
}