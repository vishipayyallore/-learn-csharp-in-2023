using A1SimpleGame.Src.Actions;
using A1SimpleGame.Src.Characters;
using A1SimpleGame.Src.Map;
using A1SimpleGame.Src.Text;

SpecifyText.LoadLanguage(new English());

ForegroundColor = ConsoleColor.Cyan;

WriteLine(SpecifyText.Language.ChooseYourName);

var name = ReadLine();

name = string.IsNullOrWhiteSpace(name) ? SpecifyText.Language.DefaultName : name;

var player = new Player(name);

WriteLine(SpecifyText.Language.Welcome, player.Name);

var house = new House(player);

AActions.Instance.Register(new Go(house));

var executing = true;
Room? lastRoom = default;

while (executing)
{
    if (lastRoom != house!.CurrentRoom)
    {
        WriteLine(house?.CurrentRoom?.ToString());
        lastRoom= house!.CurrentRoom;
    }

    WriteLine(SpecifyText.Language.WhatToDo);

    var input = ReadLine()?.ToLower();
}

ForegroundColor = ConsoleColor.Yellow;
WriteLine("\nThank You. Visit Again!");

ResetColor();
