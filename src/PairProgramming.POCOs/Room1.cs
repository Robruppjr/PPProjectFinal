namespace PairProgramming.POCOs;
public class Room1 : IRooms
{
    public bool ExitUnlocked { get; set; } = false;
    public string Password { get; set; } = "123";
    public string RoomDescription { get ; set ; }
    public string Clue { get ; set ; }

}
