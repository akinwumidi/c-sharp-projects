public class Video
{

    public string _title;
    public string _author;
    public double _length;


    //Created a list to add the comments on each video
    List<string> comments = new List<string>();

    //Created a constructor function to set the member variables.
    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    //Setter method to populate the empty comment list.
    public void addComentsToList(string c)
    {
        comments.Add(c);
    }

    //Getter method to display the properties of the videos.
    public void displayVideo()
    {
        Console.WriteLine();
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Duration: {_length}mins");
        Console.WriteLine($"Posted by: {_author}\n___________________ ");
        Console.WriteLine($" {comments.Count()} comments");
        Console.WriteLine();

        //Loop through all the elemets inside the list and print them out in the console.
        foreach (var com in comments)
        {
            Console.WriteLine(com);
            Console.WriteLine();
        }
    }
}