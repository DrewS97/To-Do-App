using System;

namespace ToDoList {
  class Program {
    public static void Main (string[] args) {
      Task.TDList.Add(new Task("Prepare Gear", "Fight Prep", new DateTime(2021, 10, 01, 8, 0, 0)));
      Task.TDList.Add(new Task("Gather Ingredients", "Fight Prep", new DateTime(2021, 10, 01, 9, 0, 0)));
      Task.TDList.Add(new Task("Dishes", "Darn Chores", new DateTime(2021, 10, 01, 10, 0, 0)));
      Task.TDList.Add(new Task("Create Potions", "Fight Prep", new DateTime(2021, 10, 01, 11, 0, 0)));
      Task.TDList.Add(new Task("Slay Dragon", "Fight with Eriluth in Nether", new DateTime(2021, 10, 01, 12, 0, 0)));
      Task.TDList.Add(new Task("Raise the Dead", "Perform satanic ritual.", new DateTime(2021, 10, 01, 13, 0, 0)));
    
      Menu.Menus();
    }
  }
}