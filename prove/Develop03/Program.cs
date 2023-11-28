using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to Sam's Scripture Memorizer!");
        Console.WriteLine("Please enter the scripture test file name: ");
        string filename = Console.ReadLine();
        /// TODO 
        bool isallHidden = false;
        string book = "billy";
        int chapter = -1;
        int startVerse = -1;
        int endVerse = -1;
        string text = "ohmydarlingohmydarlingohmydaaaaarlingclemontine";
        try
        {
            string[] lines = System.IO.File.ReadAllLines("C:/Users/samue/OneDrive/Desktop/cse210-hw/cse210-hw/prove/Develop03/" + filename);

            if (lines[0].Contains("-"))
            {
                lines[0].Replace("-", "|");
                string[] parts = lines[0].Split("|");

                book = parts[0];
                chapter = int.Parse(parts[1]); // Need to convert to int
                startVerse = int.Parse(parts[2]);
                endVerse = int.Parse(parts[3]);
                text = parts[4];
            }
            else
            {
                string[] parts = lines[0].Split("|");

                book = parts[0];
                chapter = int.Parse(parts[1]); // Need to convert to int
                startVerse = int.Parse(parts[2]); // need to convert to int 
                text = parts[3];
            }
           

        }
        catch (Exception)
        {
            Console.WriteLine("An error occured loading the file.");
        }

        Console.WriteLine("Load sucessful");

        Reference reference = new Reference(book, chapter, startVerse);
        Scripture scripture = new Scripture(reference, text);
        string displayText = scripture.displayAllText();
        string displayReference = reference.Display();
        Console.WriteLine($"{displayReference} {displayText}");
        // LOOP GO HERE
        Console.WriteLine("Enter the number of words to hide");
        int wordstohide = int.Parse(Console.ReadLine());
        scripture.hideWords(wordstohide);
        string input = "";
        try
        {
            do
            {
              //  Console.Clear(); for a reason I cannot understand at this present time this single line of code is set out to defeat me entirely. 
                displayText = scripture.displayAllText();
                displayReference = reference.Display();
                Console.WriteLine($"{displayReference} {displayText}");
                Console.WriteLine("Please press enter to hide more words or type quit");
                input = Console.ReadLine();
                wordstohide = wordstohide++;
                scripture.hideWords(wordstohide);
                isallHidden = scripture.isCompletelyHidden();

            } while (input != "quit" && isallHidden == false);
            Console.WriteLine("Thank you for playing!");
        }catch(System.IO.IOException){
            Console.WriteLine("The console attempted to clear but could not.");
           
        }
    }
}

