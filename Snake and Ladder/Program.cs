namespace Snake_and_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // this is uc 1
            int start = 0;
            int player1 = 0;

            Console.WriteLine($"{start} and   {player1}");

            //This is uc 2
            
            Random rnd = new Random();
            int dice = rnd.Next(1, 7);
            Console.WriteLine($"Number between 1 to 6 is : {dice}");
        }
    }
}
