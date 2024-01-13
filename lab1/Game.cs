using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Game
    {
        public Game(GameAccount player1, GameAccount player2, double ExpectedRating)
        {
            Random random = new Random();
            int game_decicion = random.Next(0, 2);
            int GameId = random.Next(100000000, 900000000);
            Console.WriteLine(GameId);
            try
            {
                if (ExpectedRating < 0.0)
                {
                    throw new ArgumentException("Rating change cannot be less than zero!");
                }
                else if (game_decicion == 0)
                {
                    player1.WinGame(player2, ExpectedRating, GameId);
                    player2.LooseGame(player1, ExpectedRating, GameId);
                    Console.WriteLine(player1.UserName + " won the game!");
                }
                else
                {
                    player2.WinGame(player1, ExpectedRating, GameId);
                    player1.LooseGame(player2, ExpectedRating, GameId);
                    Console.WriteLine(player2.UserName + " won the game!");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
