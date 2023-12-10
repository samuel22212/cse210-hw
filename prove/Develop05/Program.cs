using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        int parsed;
        //menu
        GoalManager goalie = new GoalManager();
        do
        {   Console.WriteLine();
            Console.WriteLine("Welcome To the Eternal Quest!!");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"You have {goalie.GetScore()} points.");
            Console.WriteLine("1. Set a new goal");
            Console.WriteLine("2. View Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Completed Goal");
            Console.WriteLine("6. Delete Goal.");
            Console.WriteLine("7. Quit");
            string input = Console.ReadLine();
            parsed = int.Parse(input);

            if (parsed == 1)
            {
                Console.WriteLine("What type of goal would you like to make?");
                Console.WriteLine("1. Eternal Goal");
                Console.WriteLine("2. Simple Goal");
                Console.WriteLine("3. Checklist");
                input = Console.ReadLine();
                parsed = int.Parse(input);
                if (parsed == 1 || parsed == 2 || parsed == 3)
                {
                    Console.WriteLine("What is the name of your goal?");

                    if (parsed == 1)
                    {
                        goalie.CreateGoal(1);
                    }
                    else if (parsed == 2)
                    {

                        goalie.CreateGoal(2);
                    }
                    else if (parsed == 3)
                    {

                        goalie.CreateGoal(3);
                    }

                }
                else
                {
                    Console.WriteLine("Invalid selection, Please try again");
                }

            }
            else if(parsed ==2)
            {
                goalie.ViewGoals();
            }


        } while (parsed != 7);

    }
}