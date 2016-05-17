using System;
using System.Collections.Generic;

namespace AdventureGame
{
    public class Inventory
    {

        public Dictionary<string, int> InitInventory(Dictionary<string, int> playerInventory)
        {
            //reset Inventory
            playerInventory.Clear();
            playerInventory.Add("SOUL", 0);
            playerInventory.Add("STICK", 1);

            return playerInventory;
        }

        public void InventoryList(Dictionary<string, int> playerInventory)
        {
            foreach (KeyValuePair<string, int> entry in playerInventory)
            {
                Console.WriteLine("{0}/10, {1}, {2}", entry.Value, entry.Key, InventoryCheck(playerInventory, entry.Key.ToUpper(), "CHECK", 0, 0));
            }
        }

        public string InventoryCheck(Dictionary<string, int> playerInventory, string item, string action, int playerXPos = 0, int playerYPos = 0)
        {
            string output = "Item not found";

            if (playerInventory.ContainsKey(item))
            {
                switch (item)
                {
                    case "SOUL":
                        output = SoulItem(action, output);
                        break;
                    case "STICK":
                        output = StickItem(action, playerXPos, playerYPos, output);
                        break;
                }
            }
            return output;
        }

        private static string SoulItem(string action, string output)
        {
            if (action == "CHECK")
            {
                output = "Comes as standard";
            }
            return output;
        }

        private static string StickItem(string action, int playerXPos, int playerYPos, string output)
        {
            if (action == "CHECK")
            {
                output = "A stick";
                if ((playerXPos == 0) && (playerYPos == 0))
                {
                    output = "The Stick is glowing, it feels warm to your touch";
                }
            }
            return output;
        }
    }
}


