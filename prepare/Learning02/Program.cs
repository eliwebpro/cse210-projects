using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Developer";
        job1._company = "Google";
        job1._startYear = 2022;
        job1._endYear = 0;

        Job job2 = new Job();
        job2._jobTitle = "Back-End Developer";
        job2._company = "Adobe";
        job2._startYear = 2020;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Eliezio Silva";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
