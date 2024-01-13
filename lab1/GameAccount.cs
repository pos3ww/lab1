using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class GameAccount
    {
        public String UserName;
        private double CurrentRating;
        public int GamesCount;
        public List<String> PlayerHistory = new List<String>();
        public GameAccount(String UserName, double CurrentRating, int GamesCount)
        {
            this.UserName = UserName;
            this.CurrentRating = CurrentRating;
            this.GamesCount = GamesCount;
        }
        public double CurrentRatingProperty
        {
            get { return CurrentRating; }
            set
            {
                if (value <= 1.0)
                {
                    CurrentRating = 1.0;
                }
                else
                {
                    CurrentRating = value;
                }
            }
        }
        public void GetStats()
        {
            int i = 0;
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("  Player  | Opponent  |  Outcome  |   Game ID      | Rating Change");
            foreach (String item in this.PlayerHistory)
            {
                i++;
                if (i == 5)
                {
                    i = 0;
                    Console.WriteLine("  " + item);
                }
                else if (i < 5)
                {
                    Console.Write("  " + item + "    | ");
                }
            }
        }
        public void WinGame(GameAccount opponent, double ExpectedRating, int GameId)
        {

            CurrentRatingProperty += ExpectedRating;
            GamesCount += 1;
            AddToStatList(opponent, ExpectedRating, GameId, "Won!");
        }
        public void LooseGame(GameAccount opponent, double ExpectedRating, int GameId)
        {
            CurrentRatingProperty -= ExpectedRating;
            GamesCount += 1;
            AddToStatList(opponent, ExpectedRating, GameId, "Lost");
        }
        public void AddToStatList(GameAccount opponent, double ExpectedRating, int GameId, String Result)
        {
            PlayerHistory.Add(UserName);
            PlayerHistory.Add(opponent.UserName);
            PlayerHistory.Add(Result);
            PlayerHistory.Add(Convert.ToString(GameId));
            PlayerHistory.Add(Convert.ToString(ExpectedRating));
        }

    }
}
