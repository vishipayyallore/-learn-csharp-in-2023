using A1SimpleGame.Src.Text;

namespace A1SimpleGame.Src.Map;

public class Room
{
    public string Name { get; set; } = SpecifyText.Language.DefaultRoomName;

    public string Description { get; set; } = SpecifyText.Language.DefaultRoomDescription;

    public bool Visited { get; set; }

    public Dictionary<Directions, int> Neighbors { get; set; } = new()
    {
        {Directions.North, -1 },

        {Directions.East, -1 },

        {Directions.South, -1 },

        {Directions.West, -1 },

        {Directions.None, -1 },
    };

}
