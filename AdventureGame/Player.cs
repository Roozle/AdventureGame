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
            playerXPos = 0;
            playerYPos = 0;

            inventory.initInventory(playerInventory);

            return "Game reset";
        }



    }

}
