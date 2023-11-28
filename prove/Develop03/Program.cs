using System;

class Program
{
    static void Main(string[] args)
    {
        String scriptureFile = "";
        Console.WriteLine("Welcome to Sam's Scripture Memorizer!");
        Console.WriteLine("Please enter the scripture test file name: ");
        scriptureFile = Console.ReadLine();
        /// TODO 
        /// Split scriptureFile into reference and it's components and Scripture text. 
        /// 


        Reference reference = new Reference();
        Scripture scripture = new Scripture(reference);
        
        
    }
}