using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name? ");
        String firstName = Console.ReadLine();
        Console.WriteLine("What is your Last Name? ");
        String lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}. ");
    }
}