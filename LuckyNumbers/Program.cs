using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 0;
            int endNumber = 0;
            int jackpot = 10000;
            string playGame;
            int indexes = 6;
            


            //Introduce user to the game and advise user of jackpot ammount
            //Determine if user wants to exit the application.
            //Have user enter number indicating the lowest and highest values for the number range

            Console.WriteLine("Welcome to We Can Code IT's Lucky Number game. Today's winning amount for the 6 number jackpot is $" + jackpot + "!");
            Console.WriteLine("");
            Console.WriteLine("Do you wish to play? Please indicate yes or no.");
            playGame = Console.ReadLine();
            string play = playGame.ToLower();

            if (playGame == "yes")
            {
                Console.WriteLine("Please enter the smallest number you will selecting from to create your number range.");
                startNumber = int.Parse(Console.ReadLine());
                //Console.WriteLine(startNum);
                Console.WriteLine("");

                Console.WriteLine("Please enter the largest number you will be selecting from to create your number range.");
                endNumber = int.Parse(Console.ReadLine());
                //Console.WriteLine(endNum);
                Console.WriteLine("");
            }
            if (playGame == "no")
            {
                Environment.Exit(0);
            }


            // Create an array with a user determined number range.

            int[] userInput = new int[indexes];

            for (int i = 0; i < userInput.Length; i++)
            {
                Console.WriteLine("Enter a number between " + startNumber + " and " + endNumber + ".");
                userInput[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                // Validate user input. If user input is not within user determined range,
                // display the message "Invalid Input". Keep looping until user enters 6  values
                // within specified number range. 
                
                if (userInput[i] >= startNumber && userInput[i] <= endNumber)
                {
                    i = i++;
                }
                else
                {
                    i = i - 1;
                    Console.WriteLine("Invalid Input.");
                }

            }
            


            // Randomly generate 6 numbers using a for loop 

            Random r = new Random();
            int[] randomArray = new int[indexes];
            for (int z = 0; z < randomArray.Length; z++)
            {
                randomArray[z] = r.Next(startNumber, endNumber);
                Console.WriteLine("");
                Console.WriteLine("Lucky Number: " + randomArray[z]);
                Console.WriteLine("");
            }


            // Compare user input numbers to randomly genterated numbers
            // Determine how many user input numbers are the same as the 
            //randomly generated numbers

            int numbersSame = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                for (int z = 0; z < randomArray.Length; z++)
                {
                    if (userInput[i] == randomArray[z]) 
                        
                    numbersSame++;
                    z = z++;
                   
                }
            }
            Console.WriteLine("You guessed " + numbersSame + " numbers correctly!");
            Console.WriteLine("");


            // Determine amount of jackpot won

            int winnings = 0;
            winnings = jackpot / indexes * numbersSame;
            Console.WriteLine("You won $" + winnings + "!");

        }
    }
}
