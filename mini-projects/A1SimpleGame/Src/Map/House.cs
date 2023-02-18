using A1SimpleGame.Src.Characters;

namespace A1SimpleGame.Src.Map;

public partial class House
{
    private readonly Random _rnd = new(1234);

    public Player Player { get; init; }

    public int Width { get; set; }

    public int Height { get; set; }

    public House(Player player)
    {
        Player = player;
    }

}