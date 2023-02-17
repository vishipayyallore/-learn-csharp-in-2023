using A1SimpleGame.src.Characters;

ForegroundColor = ConsoleColor.Cyan;

WriteLine("Hello, what is your name?");

var name = ReadLine();

name = string.IsNullOrWhiteSpace(name) ? "No Name" : name;

var player = new Player(name);

WriteLine("Welcome {0} to A1 Simple Game!", player.Name);

ForegroundColor = ConsoleColor.Yellow;
WriteLine("\nThank You. Press any key ...");

ResetColor();
ReadKey();