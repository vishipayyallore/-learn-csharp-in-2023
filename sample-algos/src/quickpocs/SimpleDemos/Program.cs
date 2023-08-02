
ShowCaseTryParseEnumDemo();

List<List<string>> competitions = new()
{
    new() { "HTML", "C#" },
    new() { "C#", "Python" },
    new() { "Python", "HTML" }
};

List<int> results = new() { 0, 0, 1 };

WriteLine($"Winner: {TournamentWinner(competitions, results)}");

WriteLine($"Winner: {TournamentWinnerV1(competitions, results)}");

static string TournamentWinner(List<List<string>> competitions, List<int> results)
{
    Dictionary<string, int> teamPoints = new();
    int iCounter = 0;

    results.ForEach(result =>
    {
        var currentWinner = (result == 0) ? competitions[iCounter][1] : competitions[iCounter][0];
        iCounter++;

        if (teamPoints.ContainsKey(currentWinner))
        {
            teamPoints[currentWinner] += 3;
        }
        else
        {
            teamPoints.Add(currentWinner, 3);
        }
    });

    return teamPoints.OrderByDescending(x => x.Value).First().Key;
}

static string TournamentWinnerV1(List<List<string>> competitions, List<int> results)
{
    if (competitions.Count != results.Count)
    {
        throw new ArgumentException("Competitions and results lists must have the same number of elements.");
    }

    Dictionary<string, int> teamPoints = new();

    for (int i = 0; i < competitions.Count; i++)
    {
        string currentWinner = results[i] == 0 ? competitions[i][1] : competitions[i][0];

        if (teamPoints.ContainsKey(currentWinner))
        {
            teamPoints[currentWinner] += 3;
        }
        else
        {
            teamPoints.Add(currentWinner, 3);
        }
    }

    return teamPoints.OrderByDescending(x => x.Value).First().Key;
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