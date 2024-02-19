using System;

class Program
{
    static void Main(string[] args)
    {

        //Initialized a list to save the videos.
        List<Video> videos = new List<Video>();

        //Creating instances of the video class.
        Video video1 = new Video("Feather on a clyde","Michael Resenberg",3.54);
        Video video2 = new Video("Let her go","Michael Resenberg",4.00);
        Video video3 = new Video("General Conference","The Church of Jesus Christ of Latter-Day Saints",55.43);

        //Initialized an instance of the comment class.
        Comments comment = new Comments();

        //First video
        video1.addComentsToList(comment.addComments("Omotoso David","Wow such a nice song from the heart"));
        video1.addComentsToList(comment.addComments("Nathan Parrish","Wow ypu guys are really wonderful singers"));
        video1.addComentsToList(comment.addComments("Danny Buckrow","i will like to attend your gig"));

        //Second video
        video2.addComentsToList(comment.addComments("Jimmy Bush","I love this song so much"));
        video2.addComentsToList(comment.addComments("Omotoso Kehinde","I dedicate this song to my sister"));
        video2.addComentsToList(comment.addComments("Ayomide","I can feel the chills down my spine listening to this lyrics"));

        //Third video
        video3.addComentsToList(comment.addComments("Rodriguez","Such an inspiring talk from the leaders of The Church Of Jesus Christ"));
        video3.addComentsToList(comment.addComments("Antonio","I love elder Christopherson so much"));
        video3.addComentsToList(comment.addComments("Orlov","Really we need to see ourselves as children of God just as the apostles has admonished us all"));
        video3.addComentsToList(comment.addComments("Suraj Punjab","I know what the prophets are saying is very true and i know we will be blessed when we follow their admonishments"));

        //Add the videos to the video list so they can be looped and worked on.
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);


        //loop through the videos inside the list and call a function on all of them.
        foreach (var video in videos)
        {
            //Call the display methods on all the videos in the video list.
            video.displayVideo();
        }
    }
}