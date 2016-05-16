using System;
using System.Data;

namespace AdventureGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var player = new Player();
            var rooms = new Rooms();
            var roomTable = new DataTable();
            var instructions = new Instructions();
            ResetGame(player);
            MainLoop(player, rooms, roomTable, instructions);
        }

        public static Player ResetGame(Player player)
        {
            Console.WriteLine(player.spawnPlayer());
            new Rooms().initialiseRooms(player);
            return player;
        }

        private static void MainLoop(Player player, Rooms rooms, DataTable _roomTable, Instructions instructions)
        {
            try
            {
                string playerInput;

                do
                {
                    playerInput = Console.ReadLine();
                    switch (playerInput.ToUpper())
                    {
                        case "CHECK":
                            instructions.check(player);
                            break;
                        case "HELP":
                            instructions.help(player);
                            break;
                        case "MOVE":
                            Console.WriteLine("I also need a direction");
                            break;
                        case "MOVE NORTH":
                            instructions.action(player, _roomTable, "NORTH", "MOVE");
                            break;
                        case "MOVE EAST":
                            instructions.action(player, _roomTable, "EAST", "MOVE");
                            break;
                        case "MOVE SOUTH":
                            instructions.action(player, _roomTable, "SOUTH", "MOVE");
                            break;
                        case "MOVE WEST":
                            instructions.action(player, _roomTable, "WEST", "MOVE");
                            break;
                        case "LOOK":
                            instructions.action(player, _roomTable, "");
                            break;
                        case "LOOK NORTH":
                            instructions.action(player, _roomTable, "NORTH");
                            break;
                        case "LOOK EAST":
                            instructions.action(player, _roomTable, "EAST");
                            break;
                        case "LOOK SOUTH":
                            instructions.action(player, _roomTable, "SOUTH");
                            break;
                        case "LOOK WEST":
                            instructions.action(player, _roomTable, "WEST");
                            break;
                        case "TERMINATE":
                            instructions.terminate(player, rooms, _roomTable, instructions);
                            break;
                        default:
                            Console.WriteLine("Please type a valid command, use HELP for a list of commands");
                            break;
                    }
                } while (NextPlayerInput(playerInput));
            }
            catch
            {
            }
        }

        private static bool NextPlayerInput(string playerInput)
        {
            return true;
        }
    }
}