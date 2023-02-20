namespace A1SimpleGame.Src.Map;

public partial class House
{
    public Room? CurrentRoom { get; set; }

    public void GoToRoom(int index)
    {
        if (CurrentRoom is not null)
        {
            CurrentRoom.Visited = true;
        }

        CurrentRoom = Rooms[index];
    }

    public void GoToStartingRoom()
    {
        GoToRoom(_rnd.Next(0, Rooms.Length));
    }
}
