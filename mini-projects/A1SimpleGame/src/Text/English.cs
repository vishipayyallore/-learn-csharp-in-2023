namespace A1SimpleGame.Src.Text;

public class English : Language
{
    // TODO: Need to read the content from .json file.
    public English()
    {
        Welcome = "Welcome {0} to your OOP Adventure!";

        ChooseYourName = "Hello, what is your name?";

        DefaultName = "No Name";

        DefaultRoomName = "Room {0} ({1},{2})";

        DefaultRoomDescription = " You are in a {0} room with doors to the {1}.";

        ActionError = "You can't do that.";

        Go = "Go";

        GoError = "You can't go that way.";

        WhatToDo = "What do you want to do?";

        Quit = "quit";
    }

}
