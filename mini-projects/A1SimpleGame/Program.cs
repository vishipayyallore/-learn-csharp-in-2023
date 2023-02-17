using A1SimpleGame.src.Characters;
using A1SimpleGame.src.Text;

var language = new English();

ForegroundColor = ConsoleColor.Cyan;

WriteLine(language.ChooseYourName);

var name = ReadLine();

name = string.IsNullOrWhiteSpace(name) ? "No Name" : name;

var player = new Player(name);

WriteLine("Welcome {0} to A1 Simple Game!", player.Name);

ForegroundColor = ConsoleColor.Yellow;
WriteLine("\nThank You. Press any key ...");

ResetColor();
ReadKey();