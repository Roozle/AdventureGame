using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AdventureGame
{
    class Rooms
    {
        public enum RoomStateEnum
        {
            Fresh,
            Complete,
            InProgress,
            SecondCheck
        };
        struct individualRoom
        {
          public  string description { get; set; }
          public string distanceDescription {get;set;}
          public string secondDescription {get;set;}
          public RoomStateEnum roomState {get;set;}
        }
    public DataTable initialiseRooms(DataTable _roomTable)
    {
	    _roomTable.Columns.Add("PlayerX", typeof(int));
	    _roomTable.Columns.Add("PlayerY", typeof(int));
	    _roomTable.Columns.Add("RoomClass", typeof(individualRoom));

	    _roomTable.Rows.Add(5, 5, new individualRoom
        {
            distanceDescription = "There is an open field",
            description = "You are in an open field",
            secondDescription = "The faint smell of burning lingers in the air",
            roomState = RoomStateEnum.Fresh
        });

	    return _roomTable;
    }

    class room5_5
        { 

        }
    }
}
