WriteLine("Hello, what is your name?");

var name = ReadLine();

name = string.IsNullOrWhiteSpace(name) ? "No Name" : name;

WriteLine("Welcome {0} to A1 Simple Game!", name);

WriteLine("\nThank You. Press any key ...");
ReadKey();