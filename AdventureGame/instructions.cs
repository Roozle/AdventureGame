using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AdventureGame
{
    class Instructions
    {

        internal void action(Player _player,DataTable _roomTable, string p = "", string _action ="LOOK")
        {
            int playerXPos = _player.playerXPos;
            int playerYPos = _player.playerYPos;
            

            switch(p)
            {
                case "NORTH":
                    playerYPos = _player.playerYPos + 1;
                    break;
                case "EAST":
                    playerXPos = _player.playerXPos + 1;
                    break;
                case "SOUTH":
                    playerYPos = _player.playerYPos - 1;
                    break;
                case "WEST":
                    playerYPos = _player.playerYPos - 1;
                    break;
                default:
                    break;
            }
            DataRow[] result = _roomTable.Select("PlayerX = " + playerXPos + " AND PlayerY = " + playerYPos);
            if(_action == "MOVE")
            {
                if (result == null)
                {
                    Console.WriteLine("You hear a voice... DARE NOT TRAVEL THERE... you step back, afraid");
                }
                else
                {
                    _player.playerXPos = playerXPos;
                    _player.playerYPos = playerYPos;


                    foreach (DataRow row in result)
                    {

                        Rooms.individualRoom iR = new Rooms.individualRoom();
                        iR = row[2] as Rooms.individualRoom;

                        Console.WriteLine("{0}, {1}, {2}", row[0], row[1], iR.description);
                    }
                }
            }
            else
            //just looking 
            {
                foreach (DataRow row in result)
                {

                    Rooms.individualRoom iR = new Rooms.individualRoom();
                    iR = row[2] as Rooms.individualRoom;

                    Console.WriteLine("{0}, {1}, {2}", row[0], row[1], iR.distanceDescription);
                }

            }
            
        }

        internal void check(Player _player)
        {
            throw new NotImplementedException();
        }

        internal void help(Player _player)
        {
            throw new NotImplementedException();
        }

        internal void terminate(Player _player, Rooms _rooms, DataTable _roomTable, Instructions _instructions)
        {
            Console.WriteLine("Are you sure you want to terminate? This will reset your game, Y/N?");
            string playerInput = Console.ReadLine();
            switch (playerInput.ToUpper())
            {
                case "Y":
                    Program.ResetGame(_player);
                    break;
                case "N":
                    _instructions.action(_player, _roomTable, "");
                    break;
            }

        }
    }
}
