using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_Jackson_Lydia
{
    internal class Game
    {

        //property to hold the max number of players
        public int MaxPlayers { get; }

        //property to track the current number of players
        public int CurrentPlayers { get; set; }

        //constructor to initialize the game with maximum and current player counts
        public Game(int maxP, int currentP)
        {
            //sets the max number of players to a parameter
            MaxPlayers = maxP;
            //sets the current number of players to a parameter
            CurrentPlayers = currentP;
        }

        //removes a player
        public void KickPlayer()
        {
            //decreases the current player count by one
            CurrentPlayers--;
        }

        //checks the player queue and adds a player if possible
        public void CheckQueue(Queue<Player> playerQueue)
        {
            //checks if the current number of players is more than the ma
            if (CurrentPlayers < MaxPlayers)
            {
                if (playerQueue.Count > 0)
                {
                    playerQueue.Dequeue();
                    CurrentPlayers++;
                }
                else
                {
                    // prints to console there are no players in the queue
                    Console.WriteLine("No players in the queue");
                }
            }

        }
    }
}
