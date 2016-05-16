using System;
using System.Data;

namespace AdventureGame
{
    class Instructions
    {

        internal void action(Player player, string p = "", string _action ="LOOK")
        {
            int playerXPos = player.playerXPos;
            int playerYPos = player.playerYPos;


            switch (p)
            {
                case "NORTH":
                    playerYPos = player.playerYPos + 1;
                    break;
                case "EAST":
                    playerXPos = player.playerXPos + 1;
                    break;
                case "SOUTH":
                    playerYPos = player.playerYPos - 1;
                    break;
                case "WEST":
                    playerYPos = player.playerYPos - 1;
                    break;
            }

            DataRow[] result = player.roomTable.Select("PlayerX = " + playerXPos + " AND PlayerY = " + playerYPos);
            if (result.Length < 1)
            {
                if (_action == "MOVE")
                {
                    Console.WriteLine("You hear a voice... YOU DARE NOT TRAVEL THERE... you step back, afraid");

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
                    if (_action == "MOVE")
                    {
                            player.playerXPos = playerXPos;
                            player.playerYPos = playerYPos;

                            Rooms.IndividualRoom r = new Rooms.IndividualRoom();
                            r = row[2] as Rooms.IndividualRoom;

                            Console.WriteLine("{0}, {1}, {2}", row[0], row[1], r.Description);
                    }
                    else
                    //just looking 
                    {
                            Rooms.IndividualRoom r = new Rooms.IndividualRoom();
                            r = row[2] as Rooms.IndividualRoom;
                        if (r.Populated = true)
                        {
                        
                            Console.WriteLine("{0}, {1}, {2}", row[0], row[1], r.DistanceDescription);
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
            throw new NotImplementedException();
        }

        internal void Terminate(Player player, Instructions instructions)
        {
            Console.WriteLine("Are you sure you want to Terminate? This will reset your game, Y/N?");
            string readLine = Console.ReadLine();
            switch (readLine.ToUpper())
            {
                case "Y":
                    Program.ResetGame(player);
                    break;
                case "N":
                    instructions.action(player, "");
                    break;
            }

        }
    }
}
