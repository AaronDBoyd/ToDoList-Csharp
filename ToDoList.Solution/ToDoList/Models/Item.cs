using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    private static List<Item> _instances = new List<Item> {};
      // this static variable holds all instances of the Item class

    public Item(string description)
    {
      Description = description;
      _instances.Add(this); // add all created Item objects to _instances List 
    }   

    public static List<Item> GetAll() // static method to call on Item class directly to return the static variable.
    {
      return _instances; 
    }
  }
}