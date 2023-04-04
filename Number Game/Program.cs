using System;
using System.Globalization;
using System.Text;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            
            // Keep track of the number of guesses and the current user guess
            string inputVar;
            int targetNum;
            int counter = 0;
          
       
            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer
                do{
                inputVar = Console.ReadLine();
                bool result = Int32.TryParse(inputVar, out targetNum);

                if (!result) {
                    Console.WriteLine("Hmmm, that doesn't look like a number. Try again.");
                }
                else{
                    counter++;
                    if(targetNum == -1){
                        Console.WriteLine($"Darn. The number was {theNumber}.");
                    }
                    else if(targetNum < theNumber){
                    Console.WriteLine("So close. To low.");

                    }
                    else if(targetNum > theNumber){
                        Console.WriteLine("Almost. To high.");
                    }
                    else{
                        Console.WriteLine($"You got it in {counter} tries!!");
                    }
                }
                }while(targetNum != -1 && targetNum != theNumber);
               
           
            


        }
    }
}
