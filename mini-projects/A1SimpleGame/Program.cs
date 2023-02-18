using A1SimpleGame.src.Characters;
using A1SimpleGame.src.Text;

SpecifyText.LoadLanguage(new English());

ForegroundColor = ConsoleColor.Cyan;

WriteLine(SpecifyText.Language.ChooseYourName);

var name = ReadLine();

name = string.IsNullOrWhiteSpace(name) ? "No Name" : name;

var player = new Player(name);

WriteLine("Welcome {0} to A1 Simple Game!", player.Name);

ForegroundColor = ConsoleColor.Yellow;
WriteLine("\nThank You. Press any key ...");

ResetColor();
ReadKey();