using System;

namespace ToDoList {
  public class Menu {
    public static void Menus()
    {
      Console.WriteLine("------------To Do List------------");
      Console.WriteLine("1. Show List");
      Console.WriteLine("2. Add a new task");
      Console.WriteLine("3. Remove a task");
      Console.WriteLine("Enter \"q\" to quit.");
      Console.WriteLine("----------------------------------\n");

      MenuUse();
    }

    public static void MenuUse()
    {
      string answer = Console.ReadLine();

      switch(answer)
      {
        case "1":
          Console.Clear();
          Task.PrintList();
        break;

        case "2":
          Console.Clear();
          Task.AddTask();
        break;

        case "3":
          Console.Clear();
          Task.RemoveTask();
        break;

        case "q":
          Console.Clear();
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