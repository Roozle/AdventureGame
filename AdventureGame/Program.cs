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
            Player player = resetGame(player);
            
            mainLoop(player);
        }
        static Player resetGame(Player _player)
        {
            Console.WriteLine(_player.spawnPlayer());
            Console.ReadLine();
            return _player;
        }
        static void mainLoop(Player _player)
        {
            try {
                do {
                    var playerInput = Console.ReadLine();
                } while (NextPlayerInput(playerInput));
            } catch {
                
            }
        }

        private static bool NextPlayerInput(string playerInput)
        {
            // return false to exit game
            throw new NotImplementedException();
        }

    }
            
}
