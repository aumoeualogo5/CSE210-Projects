using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Paccar";
        job1._startYear = 2025;
        job1._endYear = 2055;

        Job job2 = new Job();
        job2._jobTitle = "Truck Driver";
        job2._company = "Miles Sand and Gravel";
        job2._startYear = 2021;
        job2._endYear = 2025;

    }
}