using System;

class Program
{
    static void Main(string[] args)
    {   List<Excercise> excercises = new List<Excercise>();
        Running running = new Running("October 10th 2023",10,1);
        Cycling cycling = new Cycling("Novemember 11 2023",30,11);
        Swimming swimming = new Swimming("December 16th 2023",60,60);
        excercises.Add(running);
        excercises.Add(cycling);
        excercises.Add(swimming);
        foreach(Excercise e in excercises){
            Console.WriteLine(e.GetSummary());
        }
    }
}