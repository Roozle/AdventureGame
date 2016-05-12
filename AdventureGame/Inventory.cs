using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame
{
    public class Inventory
    {

        public Dictionary<string, int> initInventory(Dictionary<string, int> _playerInventory)
        {
            //reset inventory
            _playerInventory.Clear();
            _playerInventory.Add("SOUL", 0);
            _playerInventory.Add("STICK", 1);

            return _playerInventory;
        }

        public void inventoryList(Dictionary<string, int> _playerInventory)
        {
            foreach (KeyValuePair<string, int> entry in _playerInventory)
            {
                Console.WriteLine("{0}/10, {1}, {2}", entry.Value, entry.Key, inventoryCheck(_playerInventory, entry.Key.ToUpper(), "CHECK", 0, 0));
            }
        }

        public string inventoryCheck(Dictionary<string, int> _playerInventory, string _item, string _action, int _playerXPos = 0, int _playerYPos = 0)
        {
            string output = "Item not found";

            if (_playerInventory.ContainsKey(_item))
            {
                switch (_item)
                {
                    case "SOUL":
                        output = soulItem(_action, output);
                        break;
                    case "STICK":
                        output = stickItem(_action, _playerXPos, _playerYPos, output);
                        break;
                }
            }
            return output;
        }

        private static string soulItem(string _action, string output)
        {
            if (_action == "CHECK")
            {
                output = "Comes as standard";
            }
            return output;
        }

        private static string stickItem(string _action, int _playerXPos, int _playerYPos, string output)
        {
            if (_action == "CHECK")
            {
                output = "A stick";
                if ((_playerXPos == 0) && (_playerYPos == 0))
                {
                    output = "The Stick is glowing, it feels warm to your touch";
                }
            }
            return output;
        }
    }
}


