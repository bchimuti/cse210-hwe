using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Threading.Tasks.Dataflow;

class Program
{
    public string JobTitle {get; set; }
    public string Company { get; set; }
    public int StartYear { get; set; }
    public int EndYear { get; set; }

    public void Display()
    {
        Console.WriteLine($"{JobTitle} ({Company}) {StartYear}-{EndYear}");
    }
}
class Resume
{
    public string PersonName { get; set; }
    public List<Job> Jobs { get; set; } = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Resume of: {PersonName}\n");
        Console.WriteLine("Job History:");
        foreach (var job in Jobs)
        {
            job.Display();
        
        }
    }
}
class Program
{
    static void Main()
    {
        Job job1 = new Job { JobTitle = "Software Enginer", Company = "SoftwareCorp", StartYear = 2018, EndYear = 2021 };
        job job2 = new Job { JobTitle = "Senior Developer ", Company = "DevMinds Ltd", StartYear = 2021, EndYear = 2025 };

        Resume resume = new Resume { PersonName = "Brandon Chimuti" };
        resume.Jobs.Add(job1);
        resume.Jobs.Add(job2);

        resume.Display();
    }
}
