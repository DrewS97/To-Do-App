using System;
using System.Linq;

namespace ToDoList {
  public class Menu {
    //Prints Menu
    public static void Menus()
    {
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine(" |                                   | ");
      Console.WriteLine(" |---------------Menu----------------| ");
      Console.WriteLine(" | 1. Show To Do List                | ");
      Console.WriteLine(" |-----------------------------------| ");
      Console.WriteLine(" | 2. Print Task Names               | ");
      Console.WriteLine(" |-----------------------------------| ");
      Console.WriteLine(" | 3. Add A New Task                 | ");
      Console.WriteLine(" |-----------------------------------| ");
      Console.WriteLine(" | 4. Remove A Task                  | ");
      Console.WriteLine(" |-----------------------------------| ");
      Console.WriteLine(" | Enter \"q\" to quit                 | ");
      Console.WriteLine(" |-----------------------------------| ");
      Console.WriteLine(" |                                   | \n");

      Console.ResetColor();

      MenuUse();
    }

    //Makes Menu Interactable
    public static void MenuUse()
    {
      string[] correctAnswers = new string[5] {"1", "2", "3", "4", "q"};
      string answer = Console.ReadLine();
      Console.Clear();

      //Checks for proper menu input
      while(!correctAnswers.Any(answer.Contains))
      {
        //Re-explain and ask for new answer
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("---------------------------------------------------------------------------------------------");
        Console.WriteLine("Please type one of the options and then press the Enter key: \"1\", \"2\", \"3\", \"4\", or \"q\"");
        Console.WriteLine("After this, you will either be shown your to do list, or you will be prompted for input.");
        Console.WriteLine("---------------------------------------------------------------------------------------------");
        Console.WriteLine("---1 - Shows your full to do list.");
        Console.WriteLine("---2 - Shows the names of all the tasks on your to do list.");
        Console.WriteLine("---3 - Adds a new task to your to do list.");
        Console.WriteLine("---4 - Removes a task from your to do list.");
        Console.WriteLine("---q - Exits the application.");
        Console.WriteLine("---------------------------------------------------------------------------------------------\n");
        Console.ResetColor();
        answer = Console.ReadLine();
      }

      switch(answer)
      {
        case "1":
          Task.PrintList();
        break;

        case "2":
          Task.PrintNames();
        break;

        case "3":
          Task.AddTask();
        break;

        case "4":
          Task.RemoveTask();
        break;

        case "q":
          Console.ForegroundColor = ConsoleColor.Cyan;
          Console.WriteLine("\nHave a productive day!");
        break;
      }
      
      if(answer != "q")
      {
        Menus();
      }
    }
    
  }
}