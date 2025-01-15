using System;
using Resumes;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "BilbaoLabs";
        job1._jobTitle = "Web Developer";
        job1._startYear = 2024;
        job1._endYear = 2025;

        //Second Job

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Project Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //Create My Resume
        Resume myResume = new Resume();
        myResume._name = "Isaac Maldonado";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}