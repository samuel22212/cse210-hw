using System;
public class GeneratePrompt{

   
    public static string RandomPrompt()
    {   string prompt  = " ";
        int randomNumber;
        Random RNG = new Random();
        randomNumber = RNG.Next(1,8);

        switch(randomNumber)
        {
            case 1: prompt ="Who was the most interesting person I interacted with today?";
            break;
            case 2: prompt ="What was the best part of my day";
            break;
            case 3: prompt ="How did I see the hand of the Lord in my life today?";
            break;
            case 4: prompt ="What was the strongest emotion I felt today?";
            break;
            case 5: prompt ="If I had one thing I could do over today, what would it be?";
            break;
            case 6: prompt ="What was the strongest emotion I felt today?";
            break;
            case 7: prompt = "How am I progressing towards my goals?";
            break;
            case 8: prompt = "Who did I spend most of today with and why?";
            break;

        }
        return prompt; 
    }
}