using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ToDoList {
  public class Task {
    public string Name {get; set;}
    public string Description {get; set;}
    public DateTime DeadLine {get; set;}
    public static List<Task> TDList = new List<Task>();

    public Task()
    {
      Name = "";
      Description = "";
    }

    public Task(string name, string des, DateTime deadline)
    {
      Name = name;
      Description = des;
      DeadLine = deadline;
    }

    //Prints full to do list
    public static void PrintList()
    {
      Console.BackgroundColor = ConsoleColor.DarkYellow;
      Console.ForegroundColor = ConsoleColor.Black;    
      Console.WriteLine("\n-------------------------------------------------------To Do List------------------------------------------------------------");
      foreach(Task td in TDList)
      {
        Console.WriteLine(td.ToString());
      }
      Console.ResetColor();
      Console.WriteLine("\n\n\n\n");
    }

    //Prints all tasks' names
    public static void PrintNames()
    {
      Console.WriteLine("These are all of the task names: ");
      Console.WriteLine("-------------------------------- ");
      foreach(Task td in TDList)
      {
        Console.WriteLine($"Task: {td.Name}"); 
      }
      Console.WriteLine("");
    }

    //Adds a task to list
    public static void AddTask()
    {
      //Create Name
      Console.WriteLine("\nEnter the name (20 characters or less) of your task: ");
      string name = Console.ReadLine();
      while(name.Length > 20)
      {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nEnter the name of your task: ");
        Console.ResetColor();
        name = Console.ReadLine();
      }
      
      //Create Description
      Console.WriteLine("\nEnter a description (50 characters or less) of your task: ");
      string des = Console.ReadLine();
      while(des.Length > 50)
      {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nEnter a description (50 characters or less) of your task: ");
        Console.ResetColor();
        des = Console.ReadLine();
      }

      DateTime deadline = Tools.GetDateTime();

      TDList.Add(new Task(name, des, deadline));
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine($"\n{name} successfully added to list!");
      Console.ResetColor();
    }
    
    //Removes a task from list
    public static void RemoveTask()
    {
      Console.WriteLine("Enter the name of the task you would like to remove.");
      string answer = Console.ReadLine();
  
      bool contained = false;

      while(contained == false)
      {
        foreach(Task t in TDList)
        {
          if(answer != t.Name)
          {
            continue;
          }
          else
          {
            contained = true;
            break;
          }
        }
        if(contained == false)
        {
          Console.WriteLine("\nPlease enter a vaild task name: \n");
          PrintNames();
          Console.WriteLine("\nEnter the name of the task you would like to remove.");
          answer = Console.ReadLine();
        }
      }
      
      string name = "";
      foreach(Task t in TDList)
      {
        if(t.Name == answer)
        {
          TDList.Remove(t);
          name = t.Name;
          break;
        }
        else
        {
          continue;
        }
      }
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine($"\n{name} successfully removed!\n");
      Console.ResetColor();
    }

    //For printing the list
    public override string ToString()
    {
      string tDString = String.Format($"Name: {Name, -20} | Description: {Description, -50} | Deadline: {DeadLine, -20}");
      tDString += "\n-----------------------------------------------------------------------------------------------------------------------------";
      return tDString;
    }
  }
}