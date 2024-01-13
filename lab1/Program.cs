using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            GameAccount player1 = new GameAccount("Vova", 0, 0);
            GameAccount player2 = new GameAccount("Vika", 0, 0);
            GameAccount player3 = new GameAccount("Vlad", 0, 0);
            Game game = new Game(player1, player3, 2.0);
            Game game1 = new Game(player2, player3, 4.0);
            Game game2 = new Game(player1, player2, 311.0);
            Game game3 = new Game(player1, player3, -1.0);
            Game game4 = new Game(player1, player2, 3.0);
            player1.GetStats();
            player2.GetStats();
            player3.GetStats();
           
        }

    }
}