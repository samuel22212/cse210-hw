using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobtitle="Software Engineer";
        job1._startYear=2026;
        job1._endYear=2028;
        job1._company="Bungie";


        Job job2 = new Job();
        job2._jobtitle="Senior Software Engineer";
        job2._startYear=2028;
        job2._endYear=2031;
        job2._company="343 Industries";

       

        Resume resume = new Resume();
        resume._name="Phineas Gage";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        
        resume.Display();
    }
    
        
        
    }



public class Job
{
 public string _company;
 public string _jobtitle; 
 public int _startYear;
 public int _endYear;

public void Display()
{
    Console.WriteLine($"{_jobtitle} ({_company}) {_startYear}-{_endYear} ");
}


}

public class Resume
{

public string _name;
public List<Job> _jobs = new List<Job>();

public void Display()
{
    Console.WriteLine(_name);
    Console.WriteLine("Jobs:");
    foreach (Job J in _jobs)
    {
        J.Display();
    } 

}

}