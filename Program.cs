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
            int Option = Dice.Next(1, 4);
            //Checking Option
            switch (Option)
            {
                case 1:   
                    Console.WriteLine("Player Will Stay in Same Block");
                    break;
                case 2:
                    Console.WriteLine("Player Got Ladder...");
                    break;
                case 3:
                    Console.WriteLine("Snake Bit You...");
                    break;
            }
        }
    }
}
 