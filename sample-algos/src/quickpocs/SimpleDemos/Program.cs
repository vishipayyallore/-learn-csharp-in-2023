
ShowCaseTryParseEnumDemo();

List<List<string>> competitions = new()
{
    new() { "HTML", "C#" },
    new() { "C#", "Python" },
    new() { "Python", "HTML" }
};

List<int> results = new() { 0, 0, 1 };

WriteLine($"Winner: {TournamentWinner(competitions, results)}");

static string TournamentWinner(List<List<string>> competitions, List<int> results)
{
    Dictionary<string, int> winners = new();
    int iCounter = 0;

    results.ForEach(result =>
    {
        var currentWinner = (result == 0) ? competitions[iCounter][1] : competitions[iCounter][0];
        iCounter++;

        if(winners.ContainsKey(currentWinner))
        {
            winners[currentWinner]+= 3;
        }
        else
        {
            winners.Add(currentWinner, 3);
        }
        // WriteLine(currentWinner);
    });

    
    return winners.OrderByDescending(x => x.Value).First().Key;
}

static void ShowCaseTryParseEnumDemo()
{
    ForegroundColor = ConsoleColor.DarkCyan;

    var color = "DarkCyan";
    _ = Enum.TryParse(color?.TrimEnd(), out ConsoleColor res);
    WriteLine($"Color: {res}");

    color = null;
    _ = Enum.TryParse(color?.TrimEnd(), out res);
    WriteLine($"Color: {res}");

    color = string.Empty;
    _ = Enum.TryParse(color?.TrimEnd(), out res);
    WriteLine($"Color: {res}");

    color = "";
    _ = Enum.TryParse(color?.TrimEnd(), out res);
    WriteLine($"Color: {res}");

    ResetColor();
}