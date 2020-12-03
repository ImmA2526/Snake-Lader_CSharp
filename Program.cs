using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********Welcome To Snake And Ladder************");
            int Position = 0;
            Random Dice = new Random();
            int RollDice = Dice.Next(1, 7);
            Console.WriteLine(RollDice);
        }
    }
}
 