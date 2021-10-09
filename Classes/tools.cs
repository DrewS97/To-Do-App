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

      int year = 0, month = 0, day = 0, hour = 0, minute = 0;
      string yearlen = "", monthlen = "", daylen = "", hourlen = "", minutelen = "";

      int[] dTParameters = {year, month, day, hour, minute};
      string[] dTLens = {yearlen, monthlen, daylen, hourlen, minutelen};
      int[] lowEnd = {currentYear, 1, 1, 0, 0};
      int[] highEnd = {2200, 12, 31, 23, 59};
      int[] inputSize = {4, 2, 2, 2, 2};
      string[] creatingDeadline = {
        "\nCreating the deadline - Enter the year in this format: yyyy",
        "\nCreating the deadline - Enter the month in this format: mm",
        "\nCreating the deadline - Enter the day in dd: ",
        "\nCreating the deadline - Enter the hour in hh: ",
        "\nCreating the deadline - Enter the minute in mm: "
      };
      string[] errorMessages = {
        $"\nPlease enter a 4 digit year between {lowEnd[0]} and 2200 in this format: yyyy.",
        "\nPlease enter a 2 digit month (01-12) in this format: mm.",
        "\nPlease enter a 2 digit day (01-31) in this format: dd.",
        "\nPlease enter a 2 digit hour (00-23) in this format: hh.",
        "\nPlease enter a 2 digit minute (00-59) in this format: mm."
      };
      
      while(deadline <= now)
      {
        int[] values = DateTimePrompt(dTParameters, dTLens, creatingDeadline, errorMessages, lowEnd, highEnd, inputSize);
        year = dTParameters[0];
        month = dTParameters[1];
        day = dTParameters[2];
        hour = dTParameters[3];
        minute = dTParameters[4];

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

    public static int[] DateTimePrompt(int[] dTParameters, string[] dTLens, string[] creatingDeadline, string[] errorMessages, int[] lowEnd, int[] highEnd, int[] inputSize)
    { 
      DateTime now = DateTime.Now;
      int currentYear = now.Year;
      int[] resultArr = new int[5];
      
      for(int i = 0; i < 5; i++)
      {
        Console.WriteLine(creatingDeadline[i]);
        dTLens[i] = Console.ReadLine();
        dTParameters[i] = 0;
        if(IsDigitsOnly(dTLens[i]) == true)
        {
          dTParameters[i] = Int32.Parse(dTLens[i]);
        }
        while(IsDigitsOnly(dTLens[i]) == false || dTLens[i].Length != inputSize[i] || dTParameters[i] > highEnd[i] || dTParameters[i] < lowEnd[i])
        {
          Console.ForegroundColor = ConsoleColor.DarkRed;
          Console.WriteLine(errorMessages[i]);
          Console.ResetColor();
          dTLens[i] = Console.ReadLine();
          dTParameters[i] = Int32.Parse(dTLens[i]);
        }
        resultArr[i] = Int32.Parse(dTLens[i]);
      }

      return resultArr;
    }

    //Makes sure a string contains only digits
    public static bool IsDigitsOnly(string str)
    {
      return str.All(char.IsDigit);
    }
  }
}