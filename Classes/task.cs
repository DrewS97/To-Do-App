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
      //Create Name
      Console.WriteLine("\nEnter the name of your task: ");
      string name = Console.ReadLine();
      
      //Create Description
      Console.WriteLine("\nEnter a description (50 characters or less) of your task: ");
      string des = Console.ReadLine();

      //Create Deadline
      Console.WriteLine("\nCreating the deadline - Enter the year in yyyy: ");
      int year = Int32.Parse(Console.ReadLine());
      Console.WriteLine("\nCreating the deadline - Enter the Month mm: ");
      int month = Int32.Parse(Console.ReadLine());
      Console.WriteLine("\nCreating the deadline - Enter the day in dd: ");
      int day = Int32.Parse(Console.ReadLine());
      Console.WriteLine("\nCreating the deadline - Enter the hour in hh: ");
      int hour = Int32.Parse(Console.ReadLine());
      Console.WriteLine("\nCreating the deadline - Enter the minute in mm: ");
      int minute = Int32.Parse(Console.ReadLine());
      Console.WriteLine("\nCreating the deadline - Enter the second in ss: ");
      int second = Int32.Parse(Console.ReadLine());

      DateTime deadline = new DateTime(year, month, day, hour, minute, second);

      TDList.Add(new Task(name, des, deadline));
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine($"{name} successfully added to list!");
      Console.ResetColor();
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