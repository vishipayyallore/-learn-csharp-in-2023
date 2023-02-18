namespace A1SimpleGame.Src.Characters;

public abstract class Character
{
    public string Name { get; init; }

    public Character(string name)
    {
        Name = name;
    }
}

