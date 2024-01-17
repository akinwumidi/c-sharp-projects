using System;

 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("############ Learning Activity W02 #############");
            Console.WriteLine("------------------------------------------------");

            Job job1 = new Job();
            job1._jobTitle = "Frontend Developer";
            job1._companyName = "Techclub NG";
            job1._startYear= 2020;
            job1._endYear= 2022;

            Job job2 = new Job();
            job2._jobTitle = "Development Team Lead";
            job2._companyName ="XeraxLabs";
            job2._startYear = 2020;
            job2._endYear = 2024;


            Resume myResume = new Resume();
            myResume._personName = "Israel Akinwumi";
            myResume._jobs.Add(job1);
            myResume._jobs.Add(job2);

            myResume.Display();

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("############ Learning Activity W02 #############");
        }
    }
 



