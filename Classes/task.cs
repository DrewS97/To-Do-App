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

      DateTime deadline = GetDateTime();

      TDList.Add(new Task(name, des, deadline));
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine($"\n{name} successfully added to list!");
      Console.ResetColor();
    }
    
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

    public static DateTime GetDateTime()
    {
      //Create Deadline
      //Year
      Console.WriteLine("\nCreating the deadline - Enter the year in this format: yyyy");
      string yearlen = Console.ReadLine();
      while(IsDigitsOnly(yearlen) == false || yearlen.Length != 4)
      {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nPlease enter a 4 digit year in this format: yyyy.");
        Console.ResetColor();
        yearlen = Console.ReadLine();
      }
      int year = Int32.Parse(yearlen);

      //Month
      Console.WriteLine("\nCreating the deadline - Enter the month in this format: mm");
      string monthlen = Console.ReadLine();
      while(IsDigitsOnly(monthlen) == false || monthlen.Length != 2)
      {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nPlease enter a 2 digit month in this format: mm.");
        Console.ResetColor();
        monthlen = Console.ReadLine();
      }
      int month = Int32.Parse(monthlen);

      //Day
      Console.WriteLine("\nCreating the deadline - Enter the day in dd: ");
      string daylen = Console.ReadLine();
      while(IsDigitsOnly(daylen) == false || daylen.Length != 2)
      {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nPlease enter a 2 digit day in this format: dd.");
        Console.ResetColor();
        daylen = Console.ReadLine();
      }
      int day = Int32.Parse(daylen);
      
      //Hour
      Console.WriteLine("\nCreating the deadline - Enter the hour in hh: ");
      string hourlen = Console.ReadLine();
      while(IsDigitsOnly(hourlen) == false || hourlen.Length != 2)
      {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nPlease enter a 2 digit hour in this format: hh.");
        Console.ResetColor();
        hourlen = Console.ReadLine();
      }
      int hour = Int32.Parse(hourlen);

      //Minute
      Console.WriteLine("\nCreating the deadline - Enter the minute in mm: ");
      string minutelen = Console.ReadLine();
      while(IsDigitsOnly(minutelen) == false || minutelen.Length != 2)
      {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nPlease enter a 2 digit minute in this format: mm.");
        Console.ResetColor();
        minutelen = Console.ReadLine();
      }
      int minute = Int32.Parse(minutelen);

      //Second
      Console.WriteLine("\nCreating the deadline - Enter the second in ss: ");
      string secondlen = Console.ReadLine();
      while(IsDigitsOnly(secondlen) == false || secondlen.Length != 2)
      {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nPlease enter a 2 digit second in this format: ss.");
        Console.ResetColor();
        secondlen = Console.ReadLine();
      }
      int second = Int32.Parse(secondlen);

      //Create DateTime with inputted information
      DateTime deadline = new DateTime(year, month, day, hour, minute, second);
      return deadline;
    }

    //Does string contain only digits?
    public static bool IsDigitsOnly(string str)
    {
      return str.All(char.IsDigit);
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