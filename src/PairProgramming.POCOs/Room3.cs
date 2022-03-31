using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Room3 : IRooms
{
    public bool ExitUnlocked { get; set; } = false;
    public string Password { get; set; } = "GROW";
    public string RoomDescription { get; set; }
    public string Clue { get; set; }

}
