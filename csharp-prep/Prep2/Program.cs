using System;

class Program
{
    static void Main(string[] args)
    {   //Declare Variables
        int grade = 0; 
        String letterGrade =" ";
        Boolean pass =false;
        Console.WriteLine("Please enter the grade percentage for this course.");
        String gradeInput = Console.ReadLine();
        int lastDigit =0;

        //determine letter grade
        if (!int.TryParse(gradeInput, out grade))
        {
            Console.WriteLine("ERROR: Please enter the grade percentage as a whole number.");
        }
        if (grade >= 90)
        {
            letterGrade = "A";
            
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
           letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        //obtains the last digit of grade for the purpose of + / - 
        lastDigit = grade%(10); 
        if (lastDigit >= 7 && letterGrade !="A" && letterGrade != "F")  
        {
            letterGrade = letterGrade +"+";
        }
        else if (lastDigit <=3 && letterGrade != "F")
        {
            letterGrade = letterGrade +"-";
        }
        //determines course passing
        if (grade >= 70)
        {
            pass = true;
        }
        if (pass == true)
        {
            Console.WriteLine("Congratulaions, you passed!");
        }
        else{
            Console.WriteLine("You did not pass this course, better luck next time.");
        }
            Console.WriteLine($"Your Grade in this class is \"{letterGrade}\" ");
            
                
            
    }
}