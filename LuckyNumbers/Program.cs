using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main()
        {

            int jackpot = 500000; //Creating an int named jackpot and assigning it a value to be midified later
            int[] luckyNums = new int[6]; //Creating empty array for randomly generated lottery numbers
            int[] userRange = new int[2]; //Creating empty array defining range of lottery numbers
            int[] userNums = new int[6]; //Creating empty array to match against luckyNums

            Console.WriteLine("The current jackpot is " + "$" + jackpot); //Displaying hard coded int (jackpot) to user
            Console.WriteLine("Please type a minimum number."); 
            userRange[0] = int.Parse(Console.ReadLine());
            // ^Prompting user to set minimum number for lottoNums and assigning user input as value for index 0

            Console.WriteLine("Please type a maximum number.");
            userRange[1] = int.Parse(Console.ReadLine());
            // ^Prompting user to set maximum number for lottoNums and assigning user input as value for index 1

            Console.WriteLine("Please enter six numbers within the range you previously defined.");
            // ^Prompting user to enter six numbers to populate the userNums array with

            for (int i = 0; i < userNums.Length; i++)
            {
                int input = int.Parse(Console.ReadLine()); //Reading user input

                if (userRange[0] > (input) || userRange[1] < (input)) //Checking that user input is within previously defined range
                {
                    Console.WriteLine("This number is not within the range you specified. Please eneter a number within the specified range of " + userRange[0] + " and " + userRange[1]);
                    //Instructing user to enter a different number upon detecting a number entry that is outside the specified range
                    input = int.Parse(Console.ReadLine()); //Reading user input after re-entry
                }
                userNums[i] = input; //Assigning the user defined values to array userNums
            }


            Random rand = new Random(); //Instantiating new random object (rand)
            for (int i = 0; i < 6; i++) //Starting loop to generate random integers
            {
                luckyNums[i] = rand.Next(userRange[0], userRange[1]); //Generating random integers within user defined range and assigning them as values to array luckyNums
            }
            Console.WriteLine("Lucky Number: " + luckyNums[0]);
            Console.WriteLine("Lucky Number: " + luckyNums[1]);
            Console.WriteLine("Lucky Number: " + luckyNums[2]);
            Console.WriteLine("Lucky Number: " + luckyNums[3]);
            Console.WriteLine("Lucky Number: " + luckyNums[4]);
            Console.WriteLine("Lucky Number: " + luckyNums[5]);
            // ^Displaying randomly generated values of luckyNums in console

            int matches = userNums.Intersect(luckyNums).Count(); //Comparing userNums to luckyNums and counting the amount of elements in common

            if (matches == 6)
            {
                Console.WriteLine("You guessed 6 numbers correctly!");
                jackpot = 500000 * 6;
                Console.WriteLine("You have won " + "$" + jackpot + ".00!");
            }
            else if (matches == 5)
            {
                Console.WriteLine("You guessed 5 numbers correctly!");
                jackpot = 500000 * 5;
                Console.WriteLine("You have won " + "$" + jackpot + ".00!");
            }
            else if (matches == 4)
            {
                Console.WriteLine("You guessed 4 numbers correctly!");
                jackpot = 500000 * 4;
                Console.WriteLine("You have won " + "$" + jackpot + "!");
            }
            else if (matches == 3)
            {
                Console.WriteLine("You guessed 3 numbers correctly!");
                jackpot = 500000 * 3;
                Console.WriteLine("You have won " + "$" + jackpot + ".00!");
            }
            else if (matches == 2)
            {
                Console.WriteLine("You guessed 2 numbers correctly!");
                jackpot = 500000 * 2;
                Console.WriteLine("You have won " + "$" + jackpot + ".00!");
            }
            else if (matches == 1)
            {
                Console.WriteLine("You guessed 1 number correctly!");
                jackpot = 500000 * 1;
                Console.WriteLine("You have won " + "$" + jackpot + ".00!");
            }
            else
            {
                Console.WriteLine("You have gueessed 0 numbers correctly!");
                jackpot = 500000 * 0;
                Console.WriteLine("You have won " + "$" + jackpot + ".00!");
            }

            Console.WriteLine("Would you like to play again?");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "yes")
            {
                Main();
            }
            else
            {
                Console.WriteLine("Thanks for Playing!");
                return;
            }
        }
    }
}
