using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //declare variables
       List<int> numbers = new List<int>();
        int number;
        
        Console.WriteLine("Please enter a list of numbers, type 0 when finished");
        //while loop for list that ends when user types 0
        do{ 
            string numInput = Console.ReadLine();
            if (!int.TryParse(numInput, out number)){
                Console.WriteLine("Error: Please enter a number");
            }
            if (number!=0){
            numbers.Add(number);
            }
            } while(number!=0);
        
        int sum = 0;

        foreach (int n in numbers)
        
        {
            sum += n;
        }
        Console.WriteLine($"The sum is {sum}.");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int maxNumber = numbers[0];
        int minNumber = numbers[0];

        foreach (int n in numbers)
        {
            if (n > maxNumber)
            {
                maxNumber = n;
            }
            if( n< minNumber)
            {
                minNumber = n;
            }

        }
            Console.WriteLine($"The highest number is: {maxNumber}");
            Console.WriteLine($"The lowest number is: {minNumber}");
    }

}