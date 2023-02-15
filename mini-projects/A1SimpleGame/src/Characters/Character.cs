namespace A1SimpleGame.src.Characters;

public abstract class Character
{
    public string Name { get; init; }

    public Character(string name)
    {
        Name = name;
    }
}

