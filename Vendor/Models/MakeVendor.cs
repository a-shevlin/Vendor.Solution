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
    private static List<MakeVendor> _instance = new List<MakeVendor> {};

    public MakeVendor(string name, string description)
    {
      Name = name;
      Description = description;
      Orders = new List<Order> {};
      _instance.Add(this);
      Id = _instance.Count;
    }
  }
}