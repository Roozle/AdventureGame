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
            Player player = new Player();
            Inventory inventory = new Inventory();
            player = resetGame(player);
            
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
            Console.ReadLine();
            doStuff();
            mainLoop(_player);
        }

        private static void doStuff()
        {
            throw new NotImplementedException();
        }

    }
            
}
