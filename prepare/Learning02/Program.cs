using System;

class Program {
    static void Main(string[] args){
        Job job1 = new Job();
        Job job2 = new();
        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2016;
        job1._endYear = 2019;
        
        job2._company = "Microsoft";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2020;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Ezequiel Videla";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResumeDetails();
    }
}