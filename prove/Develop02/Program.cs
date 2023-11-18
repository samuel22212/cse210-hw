using System;

class Program
{
    static void Main(string[] args)
    {
        String input = "";
        Journal journal = new Journal();
        Console.WriteLine("Welcome to your Digital Journal!");
        while (input != "5")
        {   Console.WriteLine();
            Console.WriteLine("Please select an option: ");
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal to file");
            Console.WriteLine("4. Load Journal from file");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            input = Console.ReadLine();
            if (input == "1")
            {
                journal.AddEntry();
            }
            else if (input == "2")
            {
                journal.DisplayAll();
            }
            else if (input == "3")
            {   
                Console.WriteLine("Please enter the name for your file");
                String saveInput = Console.ReadLine();
                journal.Save(saveInput);

            }
            else if (input =="4")
            {
               // journal.Load()
            }
            else if (input =="5")
            {
                Console.WriteLine("Goodbye for now");
            }
            else{
                Console.WriteLine("please enter an option number");
            }
        }
    }
}