using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        String userName = promptUserName();
        int favNumber = promptUserNumber();
        int squaredNumber = squareNumber(favNumber);
        displayResult(userName,squaredNumber);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }


    static String promptUserName()
{
    Console.WriteLine("Please enter your Username: ");
    String userName = Console.ReadLine();
    return userName;
}

 static int promptUserNumber()
{
    Console.WriteLine("Please enter your favorite whole number: ");
    String inputNumber = Console.ReadLine();
    int userNumber = Int32.Parse(inputNumber);
    return userNumber;
}

static int squareNumber(int n){
    int squareNumber = n *n;
    return squareNumber;
}

static void displayResult(String name, int FavNumSq)
{
  Console.WriteLine($"{name}, the square of your favorite number is {FavNumSq} ");
}
}
