using System;
using System.Data;

namespace AdventureGame
{
    class Instructions
    {

        internal void Action(Player player, string p = "", string action ="LOOK")
        {
            int playerXPos = player.PlayerXPos;
            int playerYPos = player.PlayerYPos;


            switch (p)
            {
                case "NORTH":
                    playerYPos = player.PlayerYPos + 1;
                    break;
                case "EAST":
                    playerXPos = player.PlayerXPos + 1;
                    break;
                case "SOUTH":
                    playerYPos = player.PlayerYPos - 1;
                    break;
                case "WEST":
                    playerXPos = player.PlayerXPos - 1;
                    break;
            }

            DataRow[] result = player.RoomTable.Select("PlayerX = " + playerXPos + " AND PlayerY = " + playerYPos);
            if (result.Length < 1)
            {
                if (action == "MOVE")
                {
                    Console.WriteLine("You hear a voice... YOU DARE NOT TRAVEL THERE MORTAL ... you step back, afraid");

                }
                else
                {
                    Console.WriteLine("You see nothing but a lack of creativity");
                }
            }
            else
            {
                foreach (DataRow row in result)
                {                        
                    Rooms.IndividualRoom individualRoom = new Rooms.IndividualRoom();
                    individualRoom = row[2] as Rooms.IndividualRoom;

                    if (action == "MOVE")
                    {
                        player.PlayerXPos = playerXPos;
                        player.PlayerYPos = playerYPos;

                        if (individualRoom.RoomState == Rooms.RoomStateEnum.Fresh)
                        {
                            individualRoom.RoomState = Rooms.RoomStateEnum.InProgress;
                        }

                        Console.WriteLine("{0}, {1}, {2}", row[0], row[1], individualRoom.Description);
                    }
                    else
                    //just looking 
                    {

                        if (individualRoom.Populated = true)
                        {
                            Console.WriteLine("{0}, {1}, {2}", row[0], row[1], individualRoom.DistanceDescription);
                        }
                    }
                }
            }
        }

        internal void Check(Player player)
        {
            throw new NotImplementedException();
        }

        internal void Help(Player player)
        {
            Console.WriteLine("Commands are: CHECK, MOVE, LOOK, HELP, TERMINATE, RESET");
        }

        internal void Terminate(Player player, Instructions instructions)
        {
            Console.WriteLine("Are you sure you want to Terminate? This will close the game, Y/N?");
            string readLine = Console.ReadLine();
            switch (readLine.ToUpper())
            {
                case "Y":
                    Environment.Exit(0);
                    break;
                case "N":
                    instructions.Action(player, "");
                    break;
            }
        }
        internal void Reset(Player player, Instructions instructions)
        {
            Console.WriteLine("Are you sure you want to Exit? This will reset the game, Y/N?");
            string readLine = Console.ReadLine();
            switch (readLine.ToUpper())
            {
                case "Y":
                    Program.ResetGame(player);
                    break;
                case "N":
                    instructions.Action(player, "");
                    break;
            }
        }

    }
}
