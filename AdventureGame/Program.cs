using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame
{
    class Program
    { 

        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            Player player = new Player(); 
            resetGame(player);            
            mainLoop(player);
        }
        static Player resetGame(Player _player)
        {
            Console.WriteLine(_player.spawnPlayer());
            return _player;
        }
        static void mainLoop(Player _player)
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
                            _player.check(_player);
                            break;
                        case "HELP":
                            _player.help(_player);
                            break;
                        case "MOVE":
                            Console.WriteLine("I also need a direction");
                            break;
                        case "MOVE NORTH":
                            _player.move(_player, "NORTH");
                            break;
                        case "MOVE EAST":
                            _player.move(_player, "EAST");
                            break;
                        case "MOVE SOUTH":
                            _player.move(_player, "SOUTH");
                            break;
                        case "MOVE WEST":
                            _player.move(_player, "WEST");
                            break;
                        case "LOOK":
                            Console.WriteLine("I also need a direction");
                            break;
                        case "LOOK NORTH":
                            _player.look(_player, "NORTH");
                            break;
                        case "LOOK EAST":
                            _player.look(_player, "EAST");
                            break;
                        case "LOOK SOUTH":
                            _player.look(_player, "SOUTH");
                            break;
                        case "LOOK WEST":
                            _player.look(_player, "WEST");
                            break;
                        case "TERMINATE":
                            _player.terminate(_player);
                            break;
                        default:
                            Console.WriteLine("Please type a valid command, use HELP for a list of commands");
                            break;
                    }
                } 
                while (NextPlayerInput(playerInput));
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
