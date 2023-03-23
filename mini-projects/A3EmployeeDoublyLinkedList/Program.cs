using A3EmployeeDoublyLinkedList;

ForegroundColor = ConsoleColor.Yellow;

DoublyLinkedList l = new();

l.AddLast(7);
l.AddLast(4);
l.AddLast(12);
l.Display();

WriteLine("Size: " + l.Length());
l.AddLast(8);
l.AddLast(3);
l.Display();
WriteLine("Size: " + l.Length());

WriteLine("\n\nPress any key ...");
ReadKey();

