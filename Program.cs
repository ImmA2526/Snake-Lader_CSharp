using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********Welcome To Snake And Ladder************");
            int Position = 0;
            int Win = 100;
            while (Position != 100)
            {
                Random Dice = new Random();
                int Option = Dice.Next(0, 4);
                int RollDice = Dice.Next(1, 7);
                Console.WriteLine(RollDice);
                switch (Option)
                {
                    case 1:
                        Console.WriteLine("Player Will Stay in Same Block");
                        break;
                    case 2:
                        Console.WriteLine("Player Got Ladder...");
                        Position += RollDice;
                        break;
                    case 3:
                        Console.WriteLine("Snake Bit You...");
                        Position -= RollDice;
                        break;
                }
                if (Position == Win)
                {
                    Console.WriteLine(" Winner");
                    break;
                }
            }
        }
    }
}