using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AdventureGame
{
    public class Rooms
    {
        public enum RoomStateEnum
        {
            Fresh,
            Complete,
            InProgress,
            SecondLook
        };
       public class individualRoom
        {
          public  string description { get; set; }
          public string distanceDescription {get;set;}
          public string secondDescription {get;set;}
          public RoomStateEnum roomState {get;set;}
        }
    public DataTable initialiseRooms(Player _player)
    {
	   _player.roomTable.Columns.Add("PlayerX", typeof(int));
	   _player.roomTable.Columns.Add("PlayerY", typeof(int));
	   _player.roomTable.Columns.Add("RoomClass", typeof(individualRoom));

	    
        _player.roomTable.Rows.Add(5, 5, new individualRoom
        {
            distanceDescription = "There is an open field, smoke plumes from the EAST, to the SOUTH is an old cabin, to the WEST, the charred remains of a forest",
            description = "You are in an open field, the ground appears scorched",
            secondDescription = "The faint smell of burning lingers in the air",
            roomState = RoomStateEnum.Fresh
        });
        _player.roomTable.Rows.Add(6, 5, new individualRoom
        {
            distanceDescription = "You see a bright fire in the distance, an old wooden shed extends a cabin to the SOUTH",
            description = "A small fire burns brightly, brighter than one would expect given its size, the surrounding area is badly scorched",
            secondDescription = "This is all that remains of the fire that destroyed your surroundings",
            roomState = RoomStateEnum.Fresh
        });

	    return _player.roomTable;
    }



    }
}
