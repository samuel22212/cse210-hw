using System;
using System.ComponentModel.Design;

class Program
{ 
    static void Main(string[] args)
    {
        // menu of options
        int parsed = 0;
        Console.WriteLine("Welcome to the Mindfullness Program. I hope you enjoy your time here");
        Console.WriteLine("Please select an activity");
        do  
        {   Console.Clear();
            Console.WriteLine("Enter 1 for a relaxing breathing excercise.");
            Console.WriteLine("Enter 2 for a reflection session.");
            Console.WriteLine("Enter 3 for a grounding list making excercise.");
            Console.WriteLine("Enter 4 to see these options again.");
            Console.WriteLine("Enter 5 to quit.");
            string selection = Console.ReadLine();
            parsed = int.Parse(selection);



            Console.WriteLine("");


            if (parsed == 1)
            {
                Console.WriteLine();
                Breathing breathe = new Breathing();
                breathe.Run();
            }
            else if (parsed == 2)
            {


                Console.WriteLine();
                Reflecting reflecting = new Reflecting();
                reflecting.run();

            }
            else if (parsed == 3)
            {
                Console.WriteLine();
                Listing list = new Listing();
                list.run();
            }
            else if (parsed == 4)
            {


                Console.WriteLine();
            }


            else if (parsed == 5)
            {
                Console.WriteLine("Goodbye friend. Come again soon.");
            }

            else{

                Console.WriteLine("Please select an activity or enter 5 to quit.");
            }




        } while (parsed != 5);
    }
}



