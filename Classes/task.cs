using System;
using System.Collections.Generic;
using System.Globalization;

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

    public static void PrintList()
    {
      Console.WriteLine("\n----------------------------------------------------To Do List----------------------------------------------------------\n");
      foreach(Task td in TDList)
      {
        Console.WriteLine(td.ToString());
      }
      Console.WriteLine("\n\n\n\n");
    }

    public static void AddTask()
    {
      //Set DateTime settings
      CultureInfo enUS = new CultureInfo("en-US");
      DateTime deadline;

      //Create Name
      Console.WriteLine("\nEnter the name of your task: ");
      string name = Console.ReadLine();
      
      //Create Description
      Console.WriteLine("\nEnter a description (50 characters or less) of your task: ");
      string des = Console.ReadLine();

      //Create Deadline
      Console.WriteLine("\nEnter a deadline for when the task should be completed by in the format of: mm/dd/yyyy 00:00");
      Console.WriteLine("For example: June 1st 2020 at 1:00am would be -- 06/01/2020 13:00");
      string deadlineString = Console.ReadLine();

      //Ensure DeadLine was entered with proper formatting
      if (DateTime.TryParseExact(deadlineString, "MM/dd/yyyy hh:mm", enUS, DateTimeStyles.None, out deadline))
      {
        deadline = DateTime.Parse(deadlineString);
        TDList.Add(new Task(name, des, deadline));
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{name} successfully added to list!");
        Console.ResetColor();
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nPlease enter your deadline in the format of: mm/dd/yyyy hh:mm\n");
        Console.ResetColor();
      }
    }

    public static void RemoveTask()
    {
      Console.WriteLine("Enter the name of the task you would like to remove.");
      string answer = Console.ReadLine();

      foreach(Task t in TDList)
      {
        if(t.Name == answer)
        {
          TDList.Remove(t);
          break;
        }
        else
        {
          continue;
        }
      }
    }

    public override string ToString()
    {
      string tDString = String.Format($"Name: {Name, -15} | Description: {Description, -50} | Deadline: {DeadLine, -14}");
      tDString += "\n------------------------------------------------------------------------------------------------------------------------\n";
      return tDString;
    }
  }
}