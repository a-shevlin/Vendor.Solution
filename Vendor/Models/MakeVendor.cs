using System.Collections.Generic;
using System;

namespace Vendor.Models
{
  public class MakeVendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; set; }
    public int Id { get; }
    private static List<MakeVendor> _instances = new List<MakeVendor> {};

    public MakeVendor(string name, string description)
    {
      Name = name;
      Description = description;
      Orders = new List<Order> {};
      _instances.Add(this);
      Id = _instances.Count;
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<MakeVendor> GetList()
    {
      return _instances;
    }

    public static MakeVendor FindVendor(int id)
    {
      return _instances.Find(vendor => vendor.Id == id);
    }

    public static void RemoveVendor(int id)
    {
      MakeVendor remove = MakeVendor.FindVendor(id);
      _instances.Remove(remove);
    }
  }
}