using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Software Developer";
        job1._company = "Microsoft";
        job1._startYear = 2003;
        job1._endYear = 2006;

        Job job2 = new Job();

        job2._jobTitle = "Junior Programmer";
        job2._company = "Google";
        job2._startYear = 2000;
        job2._endYear = 2003;

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();
    }
}