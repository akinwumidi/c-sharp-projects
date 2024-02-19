using System;

class Program
{
    static void Main(string[] args)
    {
        //Reception
        //Created a new instance of the Address class
        Address recePtionAdd = new Address("47th Avenue","Time Square","Manhatma","New York","UK");
        Reception reception = new Reception();
        reception.setEvent("Receptions");
        reception.setTitle("Cultural Exhibition");
        reception.setDesc("Meet People from different parts of the world exhibiting their Cultures and Values");
        reception.setDate("19-02-2024");
        //set the getFullAdd of the add class as the parameter of the setAddress method because the getFullAdd returns a string which will be passes as address.
        reception.setAddress(recePtionAdd.getFullAdd());


        //Lecture
        Address lectureAdd = new Address("Orson Pratt Hall","Salt Lake","Jackson County","Utah","USA");
        Lecture lecture = new Lecture();
        lecture.setEvent("Lecture");
        lecture.setSpeaker("Israel Damilola Akinwumi");
        lecture.setTitle("Climate Change");
        lecture.setDesc("Lecture on the Effect of climate change on animals");
        lecture.setDate("01-03-2024");
        //set the getFullAdd of the add class as the parameter of the setAddress method because the getFullAdd returns a string which will be passes as address.
        lecture.setAddress(lectureAdd.getFullAdd());


        //Outdoor
        Address outdoorAdd = new Address("Idanre Hills","Idanre","Ondo","South west","Nigeria");
        Outdoor outdoor = new Outdoor();
        outdoor.setEvent("Tourism");
        outdoor.setTitle("Touring the ancient city of Idanre kingdom");
        outdoor.setDate("31-06-2024");
        outdoor.getWeatherInfo("Cloudy");
        //set the getFullAdd of the add class as the parameter of the setAddress method because the getFullAdd returns a string which will be passes as address.
        outdoor.setAddress(outdoorAdd.getFullAdd());

        Console.Write($"\nList of available Events\n\n1.{reception.shorDesc()}\n2.{lecture.shorDesc()}\n3.{outdoor.shorDesc()}\n\nWhich will you like to take a look at 1, 2 or 3 ?: ");
        
        string ans = Console.ReadLine();
        if(ans == "1"){
            Console.WriteLine("\n");
            reception.fullDetails();
        }else if(ans == "2"){
            Console.WriteLine("\n");
            lecture.fullDetails();
        }else if(ans == "3"){ 
            Console.WriteLine("\n");
            outdoor.fullDetails();
        }
    }
}