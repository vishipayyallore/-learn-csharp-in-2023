using A1SimpleGame.src.Characters;
using A1SimpleGame.src.Text;

SpecifyText.LoadLanguage(new English());

ForegroundColor = ConsoleColor.Cyan;

WriteLine(SpecifyText.Language.ChooseYourName);

var name = ReadLine();

name = string.IsNullOrWhiteSpace(name) ? SpecifyText.Language.DefaultName : name;

var player = new Player(name);

WriteLine(SpecifyText.Language.Welcome, player.Name);

ForegroundColor = ConsoleColor.Yellow;
WriteLine("\nThank You. Visit Again!");

ResetColor();
