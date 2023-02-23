using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello user!";
            int playerScore = 0;



            Console.WriteLine(greeting);
            Console.WriteLine("Score: " + playerScore);

            playerScore++;

            Console.WriteLine("Now the score is " + playerScore);

        }
    }
}