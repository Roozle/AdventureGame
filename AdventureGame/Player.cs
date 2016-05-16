using System;
using System.Collections.Generic;
using System.Data;


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
        }
        public Rooms rooms = new Rooms();
        public DataTable roomTable = new DataTable();
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


    }

}
