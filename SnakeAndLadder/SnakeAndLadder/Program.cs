using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadderGame
{
    internal class SnakeAndLadder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO SNAKE & LADDER PLAY");
            SnakeandLadder snake = new SnakeandLadder();
            snake.StartsGame();
            snake.RandomNumber();
            snake.TillWin();
            snake.Win();
            Console.ReadLine();
        }
    }
}