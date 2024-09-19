using System;
using System.Collections.Generic;
namespace Queues_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game(50, 49);

            Queue<Player> waitingToJoinQ = new Queue<Player>();

            Player p1 = new Player(100, "nicofreak0");
            Player p2 = new Player(100, "Nightstorm64");
            Player p3 = new Player(100, "SweetCottonTail");
            Player p4 = new Player(100, "BeetleJuiceBoi");

            p1.JoinGame(myGame, waitingToJoinQ);
            p2.JoinGame(myGame, waitingToJoinQ);
            p3.JoinGame(myGame, waitingToJoinQ);
            p4.JoinGame(myGame, waitingToJoinQ);

            Console.WriteLine("Players in the Queue:");
            foreach(Player player in waitingToJoinQ) 
            {
                Console.WriteLine(player);
            }

            myGame.KickPlayer();
            myGame.CheckQueue(waitingToJoinQ);



            Console.WriteLine("\nPlayers in the Queue:");
            foreach (Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }
        }
    }
}