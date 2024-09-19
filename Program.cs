using System;
using System.Collections.Generic;
namespace Queues_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating a new game instance with specified parameters
            Game myGame = new Game(50, 49);

            //creates a queue to manage players waiting to join the game
            Queue<Player> waitingToJoinQ = new Queue<Player>();

            // creates players with health points and gamer tags
            Player p1 = new Player(100, "nicofreak0");
            Player p2 = new Player(100, "Nightstorm64");
            Player p3 = new Player(100, "SweetCottonTail");
            Player p4 = new Player(100, "BeetleJuiceBoi");

            //players attempted to join game but go to the waiting queue if they can't
            p1.JoinGame(myGame, waitingToJoinQ);
            p2.JoinGame(myGame, waitingToJoinQ);
            p3.JoinGame(myGame, waitingToJoinQ);
            p4.JoinGame(myGame, waitingToJoinQ);

            //displays the players currently in the queue
            Console.WriteLine("Players in the Queue:");
            foreach(Player player in waitingToJoinQ) 
            {
                Console.WriteLine(player);
            }

            //the game kicks a player and checks the queue for any changes once the player has been kicked
            myGame.KickPlayer();
            myGame.CheckQueue(waitingToJoinQ);


            //displays the players still in queue
            Console.WriteLine("\nPlayers in the Queue:");
            foreach (Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }
        }
    }
}