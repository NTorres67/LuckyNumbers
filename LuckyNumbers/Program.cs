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
            double startNum = 0;
            double endNum = 0;
            double jackpot = 10000;
            string playGame;
            //double gameNum = 0;
            //double array = 0;
            //int numGood = 0;
            //int numBad = 0;

            Console.WriteLine("Welcome to We Can Code IT's Lucky Number game. Today's winning amount for the 6 number jackpot is $" + jackpot + "!");
           
            //Introduce user to the game and advise user of jackpot ammount
            //Determine if user wants to exit the application.
            //Have user enter number indicating the lowest and highest values for the number range
            Console.WriteLine("Do you wish to play? Please indicate yes or no.");
            playGame = Console.ReadLine();
            string play = playGame.ToLower();
            if (playGame == "yes")
            {
                Console.WriteLine("Please enter the smallest number you will selecting from to create your number range.");
                startNum = int.Parse(Console.ReadLine());
                //Console.WriteLine(startNum);

                Console.WriteLine("Please enter the largest number you will be selecting from to create your number range.");
                endNum = int.Parse(Console.ReadLine());
                //Console.WriteLine(endNum);
            }
            if (playGame == "")
            {
                Environment.Exit(0);
            }

            // Create an array with a user determined number range.
            // Validate user input. If user input is not within user determined range,
            // display the message "Invalid Input". Keep looping until user enters 6  values
            // within specified number range.

            double[] userInput = new double[6];
            for (int i = 0; i < userInput.Length; i++)
            {
                //int counterNumber = 0;
                Console.WriteLine("Enter a number between " + startNum + " and " + endNum + ".");
                userInput[i] = int.Parse(Console.ReadLine());
                //Console.WriteLine(nArray[i]);
                Console.WriteLine("");

                if ((userInput[i] >= startNum && userInput[i] <= endNum))
                {
                    i = i++;
                }
                else
                {
                    i = i - 1;
                    Console.WriteLine("Invalid Input.");
                }
            }
            


        }
    }
}
