using System;
using System.Numerics;
using System.Reflection.Metadata;
using System.Threading;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Snake_and_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // this is uc 1
            int start = 0;

            // uc7 player 2
            int start2 = 0;

            //This is uc 2

            Random rnd = new Random();
            int dice = 0;
            int dice2 = 0; // uc 7
            int rolled = 1;  // uc 6 
            int rolled2 = 1;
            Console.WriteLine($"Dice of player 1  is : {dice}");
            Console.WriteLine($"Dice of player 2  is : {dice2}");

            //This is uc 3
            //The Player then checks for a Option. They are No Play,
            //Ladder or Snake. - Use((RANDOM)) to check for Options - In Case of No Play the player stays in the same position
            //In Case of Ladder the player moves ahead by the number of position received in the die
            //In Case of Snake the player moves behind by the UC 3 number of position received in the die


            int option = 0;
            int Option2 = 0;
            int noplay = 0;
            int ladder = 1;
            int snake = 2;

            //This is  uc 4
            //Repeat till the Player reaches the winning
            //position 100. - Note In case the player position moves below 0, then the player restarts from 0

            while (start < 100 && start2 < 100)
            {
                option = rnd.Next(1, 4);
                dice = rnd.Next(1, 7);
                Console.WriteLine();
                Console.WriteLine($"Player 1 Rolled the dice {rolled++} times. "); // uc 6 changed

                while (option == 1)
                {
                    Console.WriteLine($"Player1 got Ladder now number currently is  : {start} and dice is : +{dice} ");
                    start += dice;
                    if (start > 100)   //uc5 Note in case the player position go above 100, the player stays in the same previous position till the player gets the exact number that adds to 100
                    {
                        start = start - dice;
                    }
                    else if (start == 100)
                    {
                        Console.WriteLine("Player 1  Got Exact Winning position 100 and won the game. ");
                    }
                    Console.WriteLine($"Position after change is {start}");
                    option = rnd.Next(1, 4);
                    Console.WriteLine($"Dice is rolled {rolled++} times. ");
                    rolled++;
                }
                if (option == 2)
                {
                    Console.WriteLine($"Player 1 Got ssnake now number currently is  : {start} and dice is : -{dice} ");
                    start -= dice;
                    Console.WriteLine($"Position after change is {start}");
                    if (start < 0) start = 0;
                }

                // uc 7 for player 2

                Option2 = rnd.Next(1, 4);
                dice2 = rnd.Next(1, 7);
                Console.WriteLine();
                Console.WriteLine($"Player 2 rolled dice {rolled2++} times. "); // uc 6 changed

                while (Option2 == 1)
                {
                    Console.WriteLine($"Player2 got Ladder now number currently is  : {start2} and dice is : +{dice2} ");
                    start2 += dice2;
                    if (start2 > 100)   //uc5 Note in case the player position go above 100, the player stays in the same previous position till the player gets the exact number that adds to 100
                    {
                        start2 = start2 - dice2;
                    }
                    else if (start2 == 100)
                    {
                        Console.WriteLine("Player 2  Got Exact Winning position 100 and won the game. ");
                    }
                    Console.WriteLine($"Position after change is {start2}");
                    Option2 = rnd.Next(1, 4);
                    Console.WriteLine($"Dice is rolled {rolled2++} times. ");
                    rolled2++;
                }
                if (Option2 == 2)
                {
                    Console.WriteLine($"Player 2 Got ssnake now number currently is  : {start2} and dice is : -{dice2} ");
                    start2 -= dice2;
                    Console.WriteLine($"Position after change is {start2}");
                    if (start2 < 0) start2 = 0;
                }

            }

        }
    }
}
