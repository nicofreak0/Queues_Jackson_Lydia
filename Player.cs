using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_Jackson_Lydia
{
    internal class Player
    {
        //holds the players health points
        public int Health {  get; set; } 

        //holds the players gamer tag
        public string GamerTag { get; }

        //initializes a player with health and a gamer tag
        public Player(int healthParam, string nameParam)
        {
            //setting parameters for health and their gamer tag
            Health = healthParam;
            GamerTag = nameParam;
        }

        public void JoinGame(Game game, Queue<Player> queue)
        {
            //checks if the current number of players has reached the maximum limit
            if (game.CurrentPlayers == game.MaxPlayers)
            {
                //if the game is full add the player to the queue
                queue.Enqueue(this);
            }
            else
            {
                //if theres room it joins them to the game
                Console.WriteLine("Joining Game.");
                game.CurrentPlayers++;
            }
        }

        //override the ToString method to return the player's gamer tag for display purposes
        public override string ToString()
        {
            //returns the gamer tag when the player is printed
            return GamerTag;
        }
    }
}
