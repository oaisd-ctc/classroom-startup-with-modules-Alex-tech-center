using System;

public class Program
{
    public static void Main(string[] args)
    {
        

        // STEP 3.b - Uncomment the lines below after your functions have been defined
         FindSeat();
         SignIn();
         DailyLogic();
         BoxBreathing(5);
         DailyHypothetical(); 
    }

        


    private static void BoxBreathing(int duration)
    {
        Console.WriteLine("Inhale for " + duration + " seconds.");
        Console.WriteLine("Hold breath for" + duration + " seconds.");
        Console.WriteLine("Exhale for " + duration + " seconds.");
        Console.WriteLine("Hold breath for " + duration +  "seconds.");
        Console.WriteLine("Inhale for " + duration + " seconds.");
        Console.WriteLine("Hold breath for " + duration + " seconds.");
        Console.WriteLine("Exhale for " + duration + " seconds.");
        Console.WriteLine("Hold breath for " + duration + " seconds.");
        Console.WriteLine("Inhale for " + duration + " seconds.");
        Console.WriteLine("Hold breath for " + duration + " seconds.");
        Console.WriteLine("Exhale for " + duration + " seconds.");
        Console.WriteLine("Hold breath for " + duration + " seconds.");
        Console.WriteLine("Inhale for " + duration + " seconds.");
        Console.WriteLine("Hold breath for " + duration + " seconds.");
        Console.WriteLine("Exhale for " + duration + " seconds.");
        Console.WriteLine("Hold breath for " + duration + " seconds.");
        Console.WriteLine("Inhale for " + duration + " seconds.");
        Console.WriteLine("Hold breath for " + duration + " seconds.");
        Console.WriteLine("Exhale for " + duration + " seconds.");
        Console.WriteLine("Hold breath for " + duration + " seconds.");
        
    }

    private static void DailyHypothetical()
    {
       Console.WriteLine("Open a new tab in the browser.");
        Console.WriteLine("Navigate to Google.");
        Console.WriteLine("Open Gmail.");
        Console.WriteLine("Read Daily Hypothetical.");
        Console.WriteLine("Talk to neighbors about Daily Hypothetical.");
        Console.WriteLine("Respond to Daily Hypothetical email.");
    }

    public static void FindSeat()
    {
Console.WriteLine("Walk in the room.");
        Console.WriteLine("Walk towards desk.");
        Console.WriteLine("Pull out chair.");
        Console.WriteLine("Take off backpack.");
        Console.WriteLine("Place backpack on the ground.");
        Console.WriteLine("Sit down in chair.");
    }

    public static void SignIn()
    {

        Console.WriteLine("Turn on computer.");
        Console.WriteLine("Sign in to computer.");
         
    }

    public static void DailyLogic()
    {
 Console.WriteLine("Open browser.");
        Console.WriteLine("Navigate to the Daily Logic Classroom.");
        Console.WriteLine("Complete the Daily Logic for the day.");
    }

    /**
    * Create functions for Box Breathing and Daily Hypotheticals below:
    */

}