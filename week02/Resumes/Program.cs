using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        //Create a new job instance named job1 .
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2018;
        job1._endYear = 2020;

        //Create a second job
        Job job2 = new Job();
        job2._jobTitle = "Web Designer";
        job2._company = "Amazon";
        job2._startYear = 2020;
        job2._endYear = 2024;

        Resume myResume = new Resume();

        //create a new instance
        myResume._name = "Bell Shen";
        //Add the two jobs you created earlier, to the list of jobs in the resume object.
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //display the name and all the jobs in one line.
        myResume.Display();



    }
}