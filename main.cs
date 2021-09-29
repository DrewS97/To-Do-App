using System;

namespace ToDoList {
  class Program {
    public static void Main (string[] args) {
      ToDos.TDList.Add(new ToDos("Mowing", "Mow and weedeat the house and parent's house.", new DateTime(2021, 10, 04, 8, 0, 0)));
      ToDos.TDList.Add(new ToDos("Breakfast", "Make breakfast for Amelia.", new DateTime(2021, 10, 01, 9, 0, 0)));
      ToDos.TDList.Add(new ToDos("Dishes", "Get Amelia cleaned up and do dishes.", new DateTime(2021, 10, 01, 10, 0, 0)));
      ToDos.TDList.Add(new ToDos("Walk Amelia", "Take an hour walk with Amelia.", new DateTime(2021, 10, 01, 11, 0, 0)));
    
      Menu.Menus();
    }
  }
}