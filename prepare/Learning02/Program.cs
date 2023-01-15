using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Customer Service";
        job1._company = "1-800-Contacts";
        job1._startYear = 2007;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Technical Support";
        job2._company = "Stubhub";
        job2._startYear = 2021;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._firstName = "Cigi";
        myResume._lastName = "Owens";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();


    }
}