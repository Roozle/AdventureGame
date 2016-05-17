using System;
using System.Data;

namespace AdventureGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var player = new Player();
            ResetGame(player);
            MainLoop(player);
        }

        public static Player ResetGame(Player player)
        {
            Console.WriteLine(player.SpawnPlayer());
            new Rooms().InitialiseRooms(player);
            return player;
        }

        private static void MainLoop(Player player)
        {
            Instructions instructions = new Instructions();
            try
            {
                string playerInput;

                do
                {
                    playerInput = Console.ReadLine();
                    switch (playerInput.ToUpper())
                    {
                        case "CHECK":
                            instructions.Check(player);
                            break;
                        case "HELP":
                            instructions.Help(player);
                            break;
                        case "MOVE":
                            Console.WriteLine("I also need a direction");
                            break;
                        case "MOVE NORTH":
                            instructions.Action(player, "NORTH", "MOVE");
                            break;
                        case "MOVE EAST":
                            instructions.Action(player, "EAST", "MOVE");
                            break;
                        case "MOVE SOUTH":
                            instructions.Action(player, "SOUTH", "MOVE");
                            break;
                        case "MOVE WEST":
                            instructions.Action(player, "WEST", "MOVE");
                            break;
                        case "LOOK":
                            instructions.Action(player,"", "");
                            break;
                        case "LOOK NORTH":
                            instructions.Action(player, "NORTH");
                            break;
                        case "LOOK EAST":
                            instructions.Action(player, "EAST");
                            break;
                        case "LOOK SOUTH":
                            instructions.Action(player, "SOUTH");
                            break;
                        case "LOOK WEST":
                            instructions.Action(player, "WEST");
                            break;
                        case "TERMINATE":
                            instructions.Terminate(player, instructions);
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