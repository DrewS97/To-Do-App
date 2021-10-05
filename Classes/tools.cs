using System;
using System.Linq;

namespace ToDoList {
  public static class Tools {
    //Prompts the user for input to create a DateTime
    public static DateTime GetDateTime()
    {
      DateTime now = DateTime.Now;
      int currentYear = now.Year;
      DateTime deadline = now;

      //Create Deadline
      while(deadline <= now)
      {  
         //Year
        Console.WriteLine("\nCreating the deadline - Enter the year in this format: yyyy");
        string yearlen = Console.ReadLine();
        int year = 0;
        if(IsDigitsOnly(yearlen) == true)
        {
          year = Int32.Parse(yearlen);
        }
        while(IsDigitsOnly(yearlen) == false || yearlen.Length != 4 || year > 2200 || year < currentYear)
        {
          Console.ForegroundColor = ConsoleColor.DarkRed;
          Console.WriteLine($"\nPlease enter a 4 digit year between {currentYear} and 2200 in this format: yyyy.");
          Console.ResetColor();
          yearlen = Console.ReadLine();
          year = Int32.Parse(yearlen);
        }
        year = Int32.Parse(yearlen);

        //Month
        Console.WriteLine("\nCreating the deadline - Enter the month in this format: mm");
        string monthlen = Console.ReadLine();
        int month = 1;
        if(IsDigitsOnly(monthlen) == true)
        {
          month = Int32.Parse(monthlen);
        }
        while(IsDigitsOnly(monthlen) == false || monthlen.Length != 2 || month > 12 || month < 1)
        {
          Console.ForegroundColor = ConsoleColor.DarkRed;
          Console.WriteLine("\nPlease enter a 2 digit month (01-12) in this format: mm.");
          Console.ResetColor();
          monthlen = Console.ReadLine();
          month = Int32.Parse(monthlen);
        }

        //Day
        Console.WriteLine("\nCreating the deadline - Enter the day in dd: ");
        string daylen = Console.ReadLine();
        int day = 0;
        if(IsDigitsOnly(daylen) == true)
        {
          day = Int32.Parse(daylen);
        }
        while(IsDigitsOnly(daylen) == false || daylen.Length != 2 || day < 0 || day > 31)
        {
          Console.ForegroundColor = ConsoleColor.DarkRed;
          Console.WriteLine("\nPlease enter a 2 digit day (01-31) in this format: dd.");
          Console.ResetColor();
          daylen = Console.ReadLine();
          day = Int32.Parse(daylen);

        }
        day = Int32.Parse(daylen);
        
        //Hour
        Console.WriteLine("\nCreating the deadline - Enter the hour in hh: ");
        string hourlen = Console.ReadLine();
        int hour = 0;
        if(IsDigitsOnly(hourlen) == true)
        {
          hour = Int32.Parse(hourlen);
        }
        while(IsDigitsOnly(hourlen) == false || hourlen.Length != 2 || hour > 23 || hour < 0)
        {
          Console.ForegroundColor = ConsoleColor.DarkRed;
          Console.WriteLine("\nPlease enter a 2 digit hour (00-23) in this format: hh.");
          Console.ResetColor();
          hourlen = Console.ReadLine();
          hour = Int32.Parse(hourlen);

        }
        hour = Int32.Parse(hourlen);

        //Minute
        Console.WriteLine("\nCreating the deadline - Enter the minute in mm: ");
        string minutelen = Console.ReadLine();
        int minute = 0;
        if(IsDigitsOnly(minutelen) == true)
        {
          minute = Int32.Parse(minutelen);
        }
        while(IsDigitsOnly(minutelen) == false || minutelen.Length != 2 || minute > 59 || minute < 0)
        {
          Console.ForegroundColor = ConsoleColor.DarkRed;
          Console.WriteLine("\nPlease enter a 2 digit minute (00-59) in this format: mm.");
          Console.ResetColor();
          minutelen = Console.ReadLine();
          minute = Int32.Parse(minutelen);

        }
        minute = Int32.Parse(minutelen);

        //Create DateTime with inputted information
        deadline = new DateTime(year, month, day, hour, minute, 00);
        if(deadline <= now)
        {
          Console.Clear();   
          Console.ForegroundColor = ConsoleColor.DarkRed;
          Console.WriteLine($"You entered {deadline}");
          Console.WriteLine("Please enter a date that is later than the present.");
          Console.ResetColor();
          
        }
      }
      return deadline;
    }

    //Makes sure a string contains only digits
    public static bool IsDigitsOnly(string str)
    {
      return str.All(char.IsDigit);
    }
  }
}