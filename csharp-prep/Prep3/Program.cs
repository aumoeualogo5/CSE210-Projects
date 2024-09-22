using System;
using System.Net;
using System.Runtime.Versioning;

class Program
{
    static void Main(string[] args)
    {
        //For Parts 1 & 2:

        Console.WriteLine9("What is the magic number?" );
        int magicNumber = int.Parse(Console.ReadLine());

        int guess = int.Parse(Console.ReadLine());

        while (guess != magicNumber)
        {
            Console.Write("What is your guess?" );
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.Write("You got it right!");
            }
        }  

        //For Part 3:
        //Random randomGenerator = new Random();
        //int magicNumber = randomGenerator.Next(1,101);
        
        string response = "yes";

        while (response == "yes")
        {
            Console.WriteLine("Would you like to continue?" );
            response = Console.ReadLine();
        }        
    }
}