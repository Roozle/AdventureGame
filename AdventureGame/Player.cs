using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AdventureGame
{
    public class Player
    {
        public enum PlayerStateEnum 
        {
            Alive,
            Dead, 
            Sleeping, 
            Moving, 
            Busy
        };
        public Inventory inventory = new Inventory();
        public Dictionary<string, int> playerInventory = new Dictionary<string, int>();
        public PlayerStateEnum playerState;
        public int playerXPos;
        public int playerYPos;

        public string spawnPlayer()
        {
            //reset state
            playerState = PlayerStateEnum.Alive;
            //reset map position
            playerXPos = 5;
            playerYPos = 5;

            inventory.initInventory(playerInventory);

            return "Game reset";
        }

        internal void move(Player _player, string p)
        {
            throw new NotImplementedException();
        }

        internal void look(Player _player, string p)
        {
            throw new NotImplementedException();
        }

        internal void check(Player _player)
        {
            throw new NotImplementedException();
        }

        internal void help(Player _player)
        {
            throw new NotImplementedException();
        }

        internal void terminate(Player _player)
        {
            Console.WriteLine("Are you sure you want to terminate? This will reset your game, Y/N?");
            Console.ReadLine();

        }
    }

}
