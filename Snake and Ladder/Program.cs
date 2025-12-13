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
            int player1 = 0;

            Console.WriteLine($"Currently start is : {start} and player is :  {player1}");

            //This is uc 2

            Random rnd = new Random();
            int dice = rnd.Next(1, 7);
            int rolled = 1;  // uc 6 
            Console.WriteLine($"Number between 1 to 6 is : {dice}");

            //This is uc 3
            //The Player then checks for a Option. They are No Play,
            //Ladder or Snake. - Use((RANDOM)) to check for Options - In Case of No Play the player stays in the same position
            //In Case of Ladder the player moves ahead by the number of position received in the die
            //In Case of Snake the player moves behind by the UC 3 number of position received in the die


            int option = rnd.Next(1, 4);
            int noplay = 0;
            int ladder = 1;
            int snake = 2;

            if (option == 1)
            {
                Console.WriteLine($"you got Ladderr now number currently is  : {start} and dice is : {dice} ");
                start += dice;
                Console.WriteLine($"Position after change is {start}");
            }
            else if (option == 2)
            {
                Console.WriteLine($"you Got ssnake now number currently is  : {start} and dice is : {dice} ");
                start -= dice;
                Console.WriteLine($"Position after change is {start}");
            }

            //This is  uc 4
            //Repeat till the Player reaches the winning
            //position 100. - Note In case the player position moves below 0, then the player restarts from 0

            while (start < 100)
            {
                option = rnd.Next(1, 4);
                dice = rnd.Next(1, 7);
                Console.WriteLine($"Dice is rolled {rolled++} times. ");  //uc c rolled count increased every time

                if (option == 1)
                {
                    Console.WriteLine($"you got Ladder now number currently is  : {start} and dice is : +{dice} ");
                    start += dice;
                    if (start > 100)   //uc5 Note in case the player position go above 100, the player stays in the same previous position till the player gets the exact number that adds to 100
                    {
                        start = start - dice;
                    }
                    else if (start == 100)
                    {
                        Console.WriteLine("Player Got Exact Winning position 100 ");
                    }
                        Console.WriteLine($"Position after change is {start}");  // uc 6 finds positon every time
                }
                else if (option == 2)
                {
                    Console.WriteLine($"you Got ssnake now number currently is  : {start} and dice is : -{dice} ");
                    start -= dice;
                    Console.WriteLine($"Position after change is {start}");
                    if (start < 0) start = 0;
                }

            }

        }
    }
}
