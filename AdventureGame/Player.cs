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
        public Rooms Rooms = new Rooms();
        public DataTable RoomTable = new DataTable();
        public Inventory Inventory = new Inventory();
        public Dictionary<string, int> PlayerInventory = new Dictionary<string, int>();
        public PlayerStateEnum PlayerState;
        public int PlayerXPos;
        public int PlayerYPos;

        public string SpawnPlayer()
        {
            //reset state
            PlayerState = PlayerStateEnum.Alive;
            //reset map position
            PlayerXPos = 5;
            PlayerYPos = 5;

            Inventory.InitInventory(PlayerInventory);

            return "Game reset";
        }


    }

}
