using System;
using System.Linq;

namespace ToDoList {
  public static class Tools {
    //Prompts the user for input to create a DateTime
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

    //Makes sure a string contains only digits
    public static bool IsDigitsOnly(string str)
    {
      return str.All(char.IsDigit);
    }
  }
}