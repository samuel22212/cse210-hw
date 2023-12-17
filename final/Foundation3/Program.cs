using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Event Information: ");
        Console.WriteLine("------------------------------");
        Lecture lecture = new Lecture("Data Science in the modern age", "This event is perfect for students looking to dip their toes into data science.", "October 10th", "5:00PM", "N Main St", "Seattle", "WA", "USA", "DR Bjorn Bjorgensen", 500);
        Console.WriteLine("\n Short Description: ");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("\n Standard Description: ");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("\n Full Details: ");
        Console.WriteLine(lecture.GetFullDetails());

        Reception reception = new Reception("Weclome Home Elder Sorensen!", "We are having a welcome home get together for our returned missionary, Elder Sorensen!", "December 31st", "8:00AM", "1234 S Baker Road", "Alpine", "UT", "USA", "KSorensen@gmail.com");
        Console.WriteLine("\n Short Description: ");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("\n Standard Description: ");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("\n Full Details: ");
        Console.WriteLine(reception.GetFullDetails());

        OutdoorEvent outdoorEvent = new OutdoorEvent("Picnic in the Park", "We are meeting for a picnic in the park this afternoon to enjoy some food and the nice weather", "June 11th", "2:00PM", "Rose Park", "Stockholm", "StockHolm County", "Sweden", "sunny with some wind");
        Console.WriteLine("\n Short Description: ");
        Console.WriteLine(outdoorEvent.GetShortDescription());
        Console.WriteLine("\n Standard Description: ");
        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine("\n Full Details: ");
        Console.WriteLine(outdoorEvent.GetFullDetails());

       
    }
}