using A1SimpleGame.Src.Map;
using A1SimpleGame.Src.Text;

namespace A1SimpleGame.Src.Actions;

public class Go : Action
{
    public override string Name => SpecifyText.Language.Go;

    private readonly House _house;

    public Go(House house)
    {
        _house = house ?? throw new ArgumentNullException(nameof(house));
    }

    public override void Execute(string[] args)
    {
        var currentRoom = _house.CurrentRoom;

        var dir = $"{args[1][..1].ToUpper()}{args[1][1..].ToLowerInvariant()}";

        _ = Enum.TryParse(dir, out Directions newDirection);

        var nextRoomIndex = currentRoom!.Neighbors[newDirection];

        if (nextRoomIndex == -1 || newDirection == Directions.None)
        {
            Console.WriteLine(SpecifyText.Language.GoError);
        }
        else
        {
            _house.GoToRoom(nextRoomIndex);
        }
    }

}