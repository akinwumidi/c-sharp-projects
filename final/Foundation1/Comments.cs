public class Comments{

    public string _commenterName;
    public string _comments;


    //Created a setter function on the comment class.
    public string addComments(string name,string com){
       
        return $"{name} comment: {com}";
    }
}