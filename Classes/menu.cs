using System;

namespace ToDoList {
  public class Menu {
    public static void Menus()
    {
      Console.WriteLine("------------To Do List------------");
      Console.WriteLine("1. Show List");
      Console.WriteLine("2. Print Task Names");
      Console.WriteLine("3. Add A New Task");
      Console.WriteLine("4. Remove A Task");
      Console.WriteLine("Enter \"q\" to quit.");
      Console.WriteLine("----------------------------------\n");

      MenuUse();
    }

    public static void MenuUse()
    {
      string answer = Console.ReadLine();
      Console.Clear();
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