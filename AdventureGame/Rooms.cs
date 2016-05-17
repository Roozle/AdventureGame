using System.Data;
using System.Security.Cryptography.X509Certificates;

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
        }
       public class IndividualRoom
        {
          public string Description { get; set; }
          public string DistanceDescription {get;set;}
          public string SecondDescription {get;set;}
          public string ThirdDescription { get; set; }
          public RoomStateEnum RoomState {get;set;}
          public bool Populated { get; set; }
          public int CheckCounter { get; set; }

        }
    public DataTable InitialiseRooms(Player player)
    {
	   player.RoomTable.Columns.Add("PlayerX", typeof(int));
	   player.RoomTable.Columns.Add("PlayerY", typeof(int));
	   player.RoomTable.Columns.Add("RoomClass", typeof(IndividualRoom));

        player.RoomTable.Rows.Add(5, 5, new IndividualRoom
        {
            DistanceDescription = "There is an open field, smoke plumes from the EAST, to the SOUTH is an old cabin, to the WEST, the charred remains of a forest",
            Description = "You are in an open field, the ground appears scorched",
            SecondDescription = "The faint smell of burning lingers in the air",
            ThirdDescription = "You feel an enormous sense of wellbeing, but something inside you tells you it's time to move on",
            RoomState = RoomStateEnum.Fresh,
            Populated = true,
            CheckCounter = 0
        });
        player.RoomTable.Rows.Add(6, 5, new IndividualRoom
        {
            DistanceDescription = "You see a bright fire in the distance, an old wooden shed extends a cabin to the SOUTH",
            Description = "A small fire burns brightly, brighter than one would expect given its size, the surrounding area is badly scorched",
            SecondDescription = "This is all that remains of the fire that destroyed your surroundings",
            RoomState = RoomStateEnum.Fresh,
            Populated = true,
            CheckCounter = 0
        });

	    return player.RoomTable;
    }
    }
}
