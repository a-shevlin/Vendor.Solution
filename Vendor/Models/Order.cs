using System;
using System.Collections.Generic;

namespace Vendor.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string title,string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this); 
      Id = _instances.Count;
    }

    public static List<Order> GetList()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order FindOrder(int id)
    {
      return _instances.Find(order => order.Id == id);
    }

    public static void RemoveOrder(int id)
    {
      Order remove = Order.FindOrder(id);
      _instances.Remove(remove);
    }
  }
}